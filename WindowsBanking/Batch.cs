using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace WindowsBanking
{
    public class Batch
    {
        /// <summary>
        /// The name of the xml input file.
        /// </summary>
        private String inputFileName;

        /// <summary>
        /// The name of the log file.
        /// </summary>
        private String logFileName;

        /// <summary>
        /// The data to be written to the log file.
        /// </summary>
        private String logData;


        private void ProcessErrors(IEnumerable<XElement> beforeQuery, IEnumerable<XElement> afterQuery, String message)
        {

        }

        private void ProcessHeader()
        {

        }

        private void ProcessDetails()
        {

        }

        private void ProcessTransactions(IEnumerable<XElement> transactionRecords)
        {

        }

        public String WriteLogData()
        {
            //to be modified
            return "";
        }

        public void ProcessTransmission(String institution, String key)
        {

        }
    }
}
