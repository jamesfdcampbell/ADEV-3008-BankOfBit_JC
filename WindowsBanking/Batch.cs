using BankOfBIT_JC.Data;
using BankOfBIT_JC.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Utility;

namespace WindowsBanking
{
    public class Batch
    {
        BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        /// <summary>
        /// The name of the xml input file.
        /// </summary>
        private string inputFileName;

        /// <summary>
        /// The name of the log file.
        /// </summary>
        private string logFileName;

        /// <summary>
        /// The data to be written to the log file.
        /// </summary>
        private string logData;

        /// <summary>
        /// Processes all detail errors found within the current file being processed.
        /// </summary>
        /// <param name="beforeQuery"></param>
        /// <param name="afterQuery"></param>
        /// <param name="message"></param>
        private void ProcessErrors(IEnumerable<XElement> beforeQuery, IEnumerable<XElement> afterQuery, string message)
        {
            if (beforeQuery.Count() != afterQuery.Count())
            {
                foreach (XElement element in beforeQuery.Except(afterQuery))
                {
                    logData += string.Format("------ERROR------\n" +
                        "File: {0}\n" +
                        "Institution: {1}\n" +
                        "Account Number: {2}\n" +
                        "TransactionType: {3}\n" +
                        "Amount: {4}\n" +
                        "Note: {5}\n" +
                        "Nodes: {6}\n" +
                        "{7}\n\n", inputFileName, element.Element("institution"), element.Element("account_no"), element.Element("type"), element.Element("amount"), element.Element("notes"), element.Nodes().Count(), message);
                }
            }
        }

        /// <summary>
        ///  Verifies the attributes of the xml file’s root element. If any of the
        ///  attributes produce an error, the file is not processed.
        /// </summary>
        private void ProcessHeader()
        {
            XDocument xDocument = XDocument.Load(inputFileName);
            XElement root = xDocument.Element("account_update");

            IEnumerable<XAttribute> attributeList = root.Attributes();

            if (attributeList.Count() != 3)
            {
                throw new Exception(string.Format("ERROR: Invalid number of attributes in file {0}.\n", this.inputFileName));
            }

            DateTime today = DateTime.Today;

            if (!DateTime.TryParse(root.Attribute("date").Value, out DateTime dateValue) || dateValue.Date != DateTime.Today)
            {
                throw new Exception(string.Format("ERROR: Date in file {0} not today's date.\n", this.inputFileName));
            }

            IQueryable<int> institutionNumbers = from results
                                                 in db.Institutions
                                                 select results.InstitutionNumber;

            if (!institutionNumbers.Contains(int.Parse(root.Attribute("institution").Value)))
            {
                throw new Exception(string.Format("ERROR: Invalid institution number found in file {0}.\n", this.inputFileName));
            }

            IEnumerable<XElement> accountNumbers = root.Descendants("account_no");
            int sumOfAcctNumbers = (from accountNumber in accountNumbers
                                    select int.Parse(accountNumber.Value)).Sum();

            if (int.Parse(root.Attribute("checksum").Value) != sumOfAcctNumbers)
            {
                throw new Exception(string.Format("ERROR: Invalid checksum found in file {0}.\n", this.inputFileName));
            }
        }

        /// <summary>
        /// Verifies the contents of the detail records in the input file.
        /// </summary>
        private void ProcessDetails()
        {
            XDocument xDocument = XDocument.Load(this.inputFileName);

            IEnumerable<XElement> firstQuery = from results in xDocument.Descendants()
                                               where results.Name == "transaction"
                                               select results;

            IEnumerable<XElement> secondQuery = from results in firstQuery
                                                where results.Nodes().Count() == 5
                                                select results;

            ProcessErrors(firstQuery, secondQuery, "ERROR: Incorrect number of child nodes.\n");

            IEnumerable<XElement> thirdQuery = from results in secondQuery
                                               where results.Element("institution").Value == xDocument.Root.Attribute("institution").Value
                                               select results;

            ProcessErrors(secondQuery, thirdQuery, "ERROR: Invalid institution node detected.\n");

            IEnumerable<XElement> fourthQuery = from results in thirdQuery
                                                where Numeric.IsNumeric(results.Element("type").Value, NumberStyles.Integer) &&
                                                Numeric.IsNumeric(results.Element("amount").Value, NumberStyles.Float)
                                                select results;

            ProcessErrors(thirdQuery, fourthQuery, "ERROR: Type or amount nodes contain data of wrong datatype.\n");

            IEnumerable<XElement> fifthQuery = from results in fourthQuery
                                               where (int.Parse(results.Element("type").Value) == 2 ||
                                               int.Parse(results.Element("type").Value) == 6)
                                               select results;

            ProcessErrors(fourthQuery, fifthQuery, "ERROR: Invalid type.\n");

            IEnumerable<XElement> sixthQuery = from results in fifthQuery
                                               where (results.Element("type").Value == "6"
                                               && results.Element("amount").Value == "0") ||
                                               (results.Element("type").Value == "2"
                                               && Numeric.IsNumeric(results.Element("amount").Value, NumberStyles.Float)
                                               && double.Parse(results.Element("amount").Value) > 0)
                                               select results;

            ProcessErrors(fifthQuery, sixthQuery, "Transaction elements contain invalid type or amount.\n");

            IEnumerable<long> dbQuery = (from results in db.BankAccounts
                                         select results.AccountNumber).ToList();

            IEnumerable<XElement> seventhQuery = from results in sixthQuery
                                                 where dbQuery.Contains(long.Parse(results.Element("account_no").Value))
                                                 select results;

            ProcessErrors(sixthQuery, seventhQuery, "ERROR: Account number not in database.\n");

            ProcessTransactions(seventhQuery);
        }

        /// <summary>
        /// Processes all valid transaction records.
        /// </summary>
        /// <param name="transactionRecords"></param>
        private void ProcessTransactions(IEnumerable<XElement> transactionRecords)
        {
            foreach (XElement transaction in transactionRecords)
            {
                BankingService.TransactionManagerClient service = new BankingService.TransactionManagerClient();

                int transactionType = int.Parse(transaction.Attribute("type").Value);
                string notes = transaction.Attribute("notes").ToString();
                long accountNumber = long.Parse(transaction.Element("account_no").Value);
                double amount = double.Parse(transaction.Element("amount").Value);
                int accountId = (from results in db.BankAccounts
                                 where results.AccountNumber == accountNumber
                                 select results.BankAccountId).FirstOrDefault();

                switch (transactionType)
                {
                    case 2:
                        double? newBalance1 = service.Withdrawal(accountId, amount, notes);
                        if (newBalance1 != null)
                        {
                            this.logData += string.Format("Transaction completed successfully: Withdrawal - ${0} withdrawn from account {1}.\n", amount, accountNumber);
                        }
                        else
                        {
                            this.logData += "Transaction completed unsuccessfully.\n";
                        }
                        break;

                    case 6:
                        double? newBalance2 = service.CalculateInterest(accountId, notes);
                        if (newBalance2 != null)
                        {
                            this.logData += string.Format("Transaction completed successfully: Interest - ${0} applied to account {1}.\n", amount, accountNumber);
                        }
                        else
                        {
                            this.logData += "Transaction completed unsuccessfully.\n";
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Writes to the log.
        /// </summary>
        /// <returns></returns>
        public string WriteLogData()
        {
            //to be modified
            StreamWriter writer = new StreamWriter(logFileName, true);
            writer.Write(logData);
            writer.Close();

            string logDataCopy = logData;

            logData = "";
            logFileName = "";

            return logDataCopy;
        }

        /// <summary>
        ///  Initiates the batch process by determining the appropriate filename and
        ///  then proceeding with the header and detail processing.
        /// </summary>
        /// <param name="institution"></param>
        /// <param name="key"></param>
        public void ProcessTransmission(string institution, string key)
        {
            inputFileName = string.Format("{0}-{1}-{2}.xml", System.DateTime.Now.Year, System.DateTime.Now.DayOfYear, institution);

            logFileName = "LOG " + Path.ChangeExtension(inputFileName, ".txt");

            if (!File.Exists(inputFileName))
            {
                logData += string.Format("File {0} does not exist.\n\n", inputFileName);
            }

            else
            {
                try
                {
                    ProcessHeader();
                    ProcessDetails();
                }

                catch (Exception ex)
                {
                    logData += string.Format("An error occurred: {0}\n", ex.Message);
                }
            }
        }
    }
}
