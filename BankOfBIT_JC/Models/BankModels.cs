/*
 * Name: James Campbell
 * Program: Business Information Technology
 * Course: ADEV-3008
 * Created: 2023-01-10
 * Updated: 2023-03-02
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using BankOfBIT_JC.Data;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;
using System.Data.SqlClient;
using System.Data;

namespace BankOfBIT_JC.Models
{
    /// <summary>
    /// AccountState Model. Represents the AccountStates table in the database.
    /// </summary>
    public abstract class AccountState
    {
        protected static BankOfBIT_JCContext db = new BankOfBIT_JCContext();
        public abstract void StateChangeCheck(BankAccount bankAccount);
        public abstract double RateAdjustment(BankAccount bankAccount);

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AccountStateId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "Lower\nLimit")]
        public double LowerLimit { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "Upper\nLimit")]
        public double UpperLimit { get; set; }

        [Required]
        [Display(Name = "Account\nState")]
        [DisplayFormat(DataFormatString = "{0:p}")]
        public double Rate { get; set; }

        public string Description
        {
            get
            {
                string input = GetType().Name;
                string output = input.Substring(0, input.IndexOf("State"));
                return output;
            }
        }

        // navigational properties
        public virtual ICollection<BankAccount> BankAccount { get; set; }
    }

    /// <summary>
    /// BronzeState model. Represents the BronzeStates table in the database.
    /// </summary>
    public class BronzeState : AccountState
    {
        private static BronzeState bronzeState { get; set; }

        private const double UPPER_LIMIT = 5000;
        private const double LOWER_LIMIT = 0;
        private const double RATE = 0.0100;

        private BronzeState()
        {
            this.UpperLimit = UPPER_LIMIT;
            this.LowerLimit = LOWER_LIMIT;
            this.Rate = RATE;
        }

        /// <summary>
        /// Returns the single instance of the BronzeState class.
        /// </summary>
        public static BronzeState GetInstance()
        {
            if (bronzeState == null)
            {
                bronzeState = db.BronzeStates.SingleOrDefault();

                if (bronzeState == null)
                {
                    bronzeState = new BronzeState();
                    db.BronzeStates.Add(bronzeState);
                    db.SaveChanges();
                }
            }

            return bronzeState;
        }

        /// <summary>
        /// Validates if the account state should change. If the balance is equal to
        /// or greater than the upper limit, the state increases. Else, it remains Bronze.
        /// </summary>
        /// <param name="bankAccount"></param>
        public override void StateChangeCheck(BankAccount bankAccount)
        {
            if (bankAccount.Balance >= UPPER_LIMIT)
            {
                bankAccount.AccountStateId = SilverState.GetInstance().AccountStateId;
            }

            else
            {
                bankAccount.AccountStateId = BronzeState.GetInstance().AccountStateId;
            }
        }

        /// <summary>
        /// Returns the adjusted rate. If the balance is less than
        ///  or equal to zero, the adjusted rate becomes 5.5%.
        /// </summary>
        /// <param name="bankAccount"></param>
        /// <returns></returns>
        public override double RateAdjustment(BankAccount bankAccount)
        {
            double adjustedRate = RATE;

            if (bankAccount.Balance <= 0)
            {
                adjustedRate = 0.055;
                return adjustedRate;
            }

            else
            {
                return adjustedRate;
            }
        }
    }

    /// <summary>
    /// SilverState model. Represents the SilverStates table in the database.
    /// </summary>
    public class SilverState : AccountState
    {
        private static SilverState silverState { get; set; }

        private const double UPPER_LIMIT = 10000;
        private const double LOWER_LIMIT = 5000;
        private const double RATE = 0.0125;

        private SilverState()
        {
            this.UpperLimit = UPPER_LIMIT;
            this.LowerLimit = LOWER_LIMIT;
            this.Rate = RATE;
        }

        /// <summary>
        /// Returns the single instance of the SilverState class.
        /// </summary>
        public static SilverState GetInstance()
        {
            if (silverState == null)
            {
                silverState = db.SilverStates.SingleOrDefault();

                if (silverState == null)
                {
                    silverState = new SilverState();
                    db.SilverStates.Add(silverState);
                    db.SaveChanges();
                }
            }

            return silverState;
        }

        /// <summary>
        /// Checks if the account balance is equal to/above the upper limit, or below
        /// the lower limit. If it is, the state increases or decreases accordingly.
        /// </summary>
        /// <param name="bankAccount"></param>
        public override void StateChangeCheck(BankAccount bankAccount)
        {
            if (bankAccount.Balance >= UPPER_LIMIT)
            {
                bankAccount.AccountStateId = GoldState.GetInstance().AccountStateId;
            }

            else if (bankAccount.Balance < LOWER_LIMIT)
            {
                bankAccount.AccountStateId = BronzeState.GetInstance().AccountStateId;
            }
        }

        /// <summary>
        /// Returns the adjusted rate, which in this case is unchanged. This
        /// method is included for consistency.
        /// </summary>
        /// <param name="bankAccount"></param>
        /// <returns></returns>
        public override double RateAdjustment(BankAccount bankAccount)
        {
            double adjustedRate = RATE;
            return adjustedRate;
        }
    }

    /// <summary>
    /// GoldState model. Represents the GoldStates table in the database.
    /// </summary>
    public class GoldState : AccountState
    {
        private static GoldState goldState { get; set; }

        private const double UPPER_LIMIT = 20000;
        private const double LOWER_LIMIT = 10000;
        private const double RATE = 0.0200;

        private GoldState()
        {

            this.UpperLimit = UPPER_LIMIT;
            this.LowerLimit = LOWER_LIMIT;
            this.Rate = RATE;
        }

        /// <summary>
        /// Returns the single instance of the GoldState class.
        /// </summary>
        public static GoldState GetInstance()
        {
            if (goldState == null)
            {
                goldState = db.GoldStates.SingleOrDefault();

                if (goldState == null)
                {
                    goldState = new GoldState();
                    db.GoldStates.Add(goldState);
                    db.SaveChanges();
                }
            }

            return goldState;
        }

        /// <summary>
        /// Validates if the account state should change. If the balance is equal to
        /// or greater than the upper limit, the state increases. If lower, it decreases.
        /// </summary>
        /// <param name="bankAccount"></param>
        public override void StateChangeCheck(BankAccount bankAccount)
        {
            if (bankAccount.Balance >= UPPER_LIMIT)
            {
                bankAccount.AccountStateId = PlatinumState.GetInstance().AccountStateId;
            }

            else if (bankAccount.Balance < LOWER_LIMIT)
            {
                bankAccount.AccountStateId = SilverState.GetInstance().AccountStateId;
            }
        }

        /// <summary>
        /// Returns the adjusted rate. If the account age is older
        /// than 10 years, 1% is added to the rate.
        /// </summary>
        /// <param name="bankAccount"></param>
        /// <returns></returns>
        public override double RateAdjustment(BankAccount bankAccount)
        {
            double adjustedRate = RATE;
            DateTime currentDate = DateTime.Now;
            DateTime tenYearsAgo = currentDate.AddYears(-10);
            if (bankAccount.DateCreated < tenYearsAgo)
            {
                adjustedRate += 0.01;
            }

            return adjustedRate;
        }
    }

    /// <summary>
    /// PlatinumState model. Represents the PlatinumStates table in the database.
    /// </summary>
    public class PlatinumState : AccountState
    {
        private static PlatinumState platinumState { get; set; }

        private const double UPPER_LIMIT = 0;
        private const double LOWER_LIMIT = 20000;
        private const double RATE = 0.0250;

        private PlatinumState()
        {
            this.UpperLimit = UPPER_LIMIT;
            this.LowerLimit = LOWER_LIMIT;
            this.Rate = RATE;
        }

        /// <summary>
        /// Returns the single instance of the PlatinumState class.
        /// </summary>
        public static PlatinumState GetInstance()
        {
            if (platinumState == null)
            {
                platinumState = db.PlatinumStates.SingleOrDefault();

                if (platinumState == null)
                {
                    platinumState = new PlatinumState();
                    db.PlatinumStates.Add(platinumState);
                    db.SaveChanges();
                }
            }

            return platinumState;
        }

        /// <summary>
        /// Validates if the account state should change. If the balance is lower
        /// than the lower limit, the state decreases.
        /// </summary>
        /// <param name="bankAccount"></param>
        public override void StateChangeCheck(BankAccount bankAccount)
        {
            if (bankAccount.Balance < LOWER_LIMIT)
            {
                bankAccount.AccountStateId = GoldState.GetInstance().AccountStateId;
            }
        }

        /// <summary>
        /// Returns the adjusted rate. If the account age is older than
        /// 10 years, 1% is added to the rate. If the account balance is
        /// more than double the lower limit, 0.5% is added to the rate.
        /// </summary>
        /// <param name="bankAccount"></param>
        /// <returns></returns>
        public override double RateAdjustment(BankAccount bankAccount)
        {
            double adjustedRate = RATE;
            double doubleLowerLimit = LOWER_LIMIT * 2;
            DateTime currentDate = DateTime.Now;
            DateTime tenYearsAgo = currentDate.AddYears(-10);
            if (bankAccount.DateCreated < tenYearsAgo)
            {
                adjustedRate += 0.01;

                if (bankAccount.Balance > doubleLowerLimit)
                {
                    adjustedRate += 0.005;
                }
            }

            else if (bankAccount.Balance > doubleLowerLimit)
            {
                adjustedRate += 0.005;
            }

            return adjustedRate;
        }
    }

    /// <summary>
    /// BankAccount model. Represents the BankAccounts table in the database.
    /// </summary>
    public abstract class BankAccount
    {
        private BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        /// <summary>
        /// Changes the account state. Runs until the criteria for the current state is met.
        /// </summary>
        public void ChangeState()
        {
            AccountState state = db.AccountStates.Find(this.AccountStateId);
            int previousState = 0;

            while (previousState != state.AccountStateId)
            {
                state.StateChangeCheck(this);
                previousState = state.AccountStateId;
                state = db.AccountStates.Find(this.AccountStateId);
            }
        }

        public abstract void SetNextAccountNumber();

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BankAccountId { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("AccountState")]
        public int AccountStateId { get; set; }

        [Display(Name = "Account\nNumber")]
        public long AccountNumber { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public double Balance { get; set; }

        [Required]
        [Display(Name = "Date\nCreated")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateCreated { get; set; }

        public string Notes { get; set; }

        public string Description
        {
            get
            {
                string input = GetType().Name;
                string output = input.Substring(0, input.IndexOf("Account"));
                return output;
            }
        }

        // navigational properties
        public virtual Client Client { get; set; }
        public virtual AccountState AccountState { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }

    /// <summary>
    /// SavingsAccount model. Represents the SavingsAccounts table in the database.
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        [Required]
        [Display(Name = "Savings Service\nCharges")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public double SavingsServicesCharges { get; set; }

        /// <summary>
        /// Calls the NextNumber stored procedure to assign
        /// the account number to the next available number.
        /// Overrides the SetNextAccountNumber superclass.
        /// </summary>
        public override void SetNextAccountNumber()
        {
            AccountNumber = (long)StoredProcedure.NextNumber("NextSavingsAccount");
        }
    }

    /// <summary>
    /// MortgageAccount model. Represents the MortgageAccounts table in the database.
    /// </summary>
    public class MortgageAccount : BankAccount
    {
        [Required]
        [Display(Name = "Mortgage\nRate")]
        [DisplayFormat(DataFormatString = "{0:p}")]
        public double MortgageRate { get; set; }

        [Required]
        public int Amortization { get; set; }

        /// <summary>
        /// Calls the NextNumber stored procedure to assign
        /// the account number to the next available number.
        /// Overrides the SetNextAccountNumber superclass.
        /// </summary>
        public override void SetNextAccountNumber()
        {
            AccountNumber = (long)StoredProcedure.NextNumber("NextMortgageAccount");
        }
    }

    /// <summary>
    /// InvestmentAccount model. Represents the InvestmentAccounts table in the database.
    /// </summary>
    public class InvestmentAccount : BankAccount
    {
        [Required]
        [Display(Name = "Interest\nRate")]
        [DisplayFormat(DataFormatString = "{0:p}")]
        public double InterestRate { get; set; }

        /// <summary>
        /// Calls the NextNumber stored procedure to assign
        /// the account number to the next available number.
        /// Overrides the SetNextAccountNumber superclass.
        /// </summary>
        public override void SetNextAccountNumber()
        {
            AccountNumber = (long)StoredProcedure.NextNumber("NextInvestmentAccount");
        }
    }

    /// <summary>
    /// ChequingAccount model. Represents the ChequingAccounts table in the database.
    /// </summary>
    public class ChequingAccount : BankAccount
    {
        [Required]
        [Display(Name = "Chequing Service\nCharges")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public double ChequingServiceCharges { get; set; }

        /// <summary>
        /// Calls the NextNumber stored procedure to assign
        /// the account number to the next available number.
        /// Overrides the SetNextAccountNumber superclass.
        /// </summary>
        public override void SetNextAccountNumber()
        {
            AccountNumber = (long)StoredProcedure.NextNumber("NextChequingAccount");
        }
    }

    /// <summary>
    /// Client Model. Represents the Clients table in the database.
    /// </summary>
    public class Client
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Display(Name = "Client\nNumber")]
        public long ClientNumber { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1)]
        [Display(Name = "First\nName")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1)]
        [Display(Name = "Last\nName")]
        public string LastName { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1)]
        public string Address { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1)]
        public string City { get; set; }

        [Required]
        [RegularExpression("^(N[BLSTU]|[AMN]B|[BQ]C|ON|PE|SK|YT)", ErrorMessage = "A valid province code is required.")]
        public string Province { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "Date\nCreated")]
        public DateTime DateCreated { get; set; }

        public string Notes { get; set; }

        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }

        [Display(Name = "Address")]
        public string FullAddress
        {
            get
            {
                return String.Format("{0} {1} {2}", Address, City, Province);
            }
        }

        /// <summary>
        /// Calls the NextNumber stored procedure to assign
        /// the client number to the next available number.
        /// </summary>
        public void SetNextClientNumber()
        {
            ClientNumber = (long)StoredProcedure.NextNumber("NextClient");
        }

        // navigational properties
        public virtual ICollection<BankAccount> BankAccount { get; set; }
    }

    /// <summary>
    /// Transaction model. Represents the Transactions table in the database.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Calls the NextNumber stored procedure to assign
        /// the client number to the next available number.
        /// </summary>
        public void SetNextTransactionNumber()
        {
            TransactionNumber = (long)StoredProcedure.NextNumber("NextTransaction");
        }
        
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }

        [ForeignKey("BankAccount")]
        public int BankAccountId { get; set; }

        [ForeignKey("TransactionType")]
        public int TransactionTypeId { get; set; }

        [Display(Name = "Number")]
        public long TransactionNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double? Deposit { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double? Withdrawal { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateCreated { get; set; }

        public string Notes { get; set; }

        public virtual BankAccount BankAccount { get; set; }
        public virtual Client Client { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }

    /// <summary>
    /// TransactionTypes model. Represents the TransactionTypes table in the database.
    /// </summary>
    public class TransactionType
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TransactionTypeId { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Description { get; set; }

        //navigational properties
        public virtual ICollection<Transaction> Transaction { get; set; }
    }

    /// <summary>
    /// Institution model. Represents the Institutions table in the database.
    /// </summary>
    public class Institution
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int InstitutionId { get; set; }

        [Required]
        [Display(Name = "Number")]
        public int InstitutionNumber { get; set; }

        [Required]
        [Display(Name = "Institution")]
        public string Description { get; set; }
    }

    /// <summary>
    /// Payee model. Represents the Payees table in the database.
    /// </summary>
    public class Payee
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PayeeId { get; set; }

        [Required]
        [Display(Name = "Payee")]
        public string Description { get; set; }
    }

    /// <summary>
    /// NextUniqueNumber model superclass.
    /// </summary>
    public abstract class NextUniqueNumber
    {
        protected static BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int NextUniqueNumberId { get; set; }

        [Required]
        public long NextAvailableNumber { get; set; }
    }

    /// <summary>
    /// NextSavingsAccount model. Extends the NextUniqueNumber superclass.
    /// </summary>
    public class NextSavingsAccount : NextUniqueNumber
    {
        private static NextSavingsAccount nextSavingsAccount { get; set; }

        private NextSavingsAccount()
        {
            this.NextAvailableNumber = 20000;
        }

        /// <summary>
        /// Returns the single instance of the NextSavingsAccount class.
        /// </summary>
        public static NextSavingsAccount GetInstance()
        {
            if (nextSavingsAccount == null)
            {
                nextSavingsAccount = db.NextSavingsAccounts.SingleOrDefault();

                if (nextSavingsAccount == null)
                {
                    nextSavingsAccount = new NextSavingsAccount();
                    db.NextSavingsAccounts.Add(nextSavingsAccount);
                    db.SaveChanges();
                }
            }
            return nextSavingsAccount;
        }
    }

    /// <summary>
    /// NextMortgageAccount model. Extends the NextUniqueNumber superclass.
    /// </summary>
    public class NextMortgageAccount : NextUniqueNumber
    {
        private static NextMortgageAccount nextMortgageAccount { get; set; }

        private NextMortgageAccount()
        {
            this.NextAvailableNumber = 200000;
        }
        
        /// <summary>
        /// Returns the single instance of the NextMortgageAccount class.
        /// </summary>
        public static NextMortgageAccount GetInstance()
        {
            if (nextMortgageAccount == null)
            {
                nextMortgageAccount = db.NextMortgageAccounts.SingleOrDefault();

                if (nextMortgageAccount == null)
                {
                    nextMortgageAccount = new NextMortgageAccount();
                    db.NextMortgageAccounts.Add(nextMortgageAccount);
                    db.SaveChanges();
                }
            }
            return nextMortgageAccount;
        }
    }

    /// <summary>
    /// NextInvestmentAccount model. Extends the NextUniqueNumber superclass.
    /// </summary>
    public class NextInvestmentAccount : NextUniqueNumber
    {
        private static NextInvestmentAccount nextInvestmentAccount { get; set; }
        
        private NextInvestmentAccount()
        {
            this.NextAvailableNumber = 2000000;
        }

        /// <summary>
        /// Returns the single instance of the NextInvestmentAccount class.
        /// </summary>
        public static NextInvestmentAccount GetInstance()
        {
            if (nextInvestmentAccount == null)
            {
                nextInvestmentAccount = db.NextInvestmentAccounts.SingleOrDefault();

                if (nextInvestmentAccount == null)
                {
                    nextInvestmentAccount = new NextInvestmentAccount();
                    db.NextInvestmentAccounts.Add(nextInvestmentAccount);
                    db.SaveChanges();
                }
            }
            return nextInvestmentAccount;
        }
    }

    /// <summary>
    /// NextChequingAccount model. Extends the NextUniqueNumber superclass.
    /// </summary>
    public class NextChequingAccount : NextUniqueNumber
    {
        private static NextChequingAccount nextChequingAccount { get; set; }
        
        private NextChequingAccount()
        {
            this.NextAvailableNumber = 20000000;
        }

        /// <summary>
        /// Returns the single instance of the NextChequingAccount class.
        /// </summary>
        public static NextChequingAccount GetInstance()
        {
            if (nextChequingAccount == null)
            {
                nextChequingAccount = db.NextChequingAccounts.SingleOrDefault();

                if (nextChequingAccount == null)
                {
                    nextChequingAccount = new NextChequingAccount();
                    db.NextChequingAccounts.Add(nextChequingAccount);
                    db.SaveChanges();
                }
            }
            return nextChequingAccount;
        }
    }

    /// <summary>
    /// NextClient model. Extends the NextUniqueNumber superclass.
    /// </summary>
    public class NextClient : NextUniqueNumber
    {
        private static NextClient nextClient;
        private NextClient()
        {
            this.NextAvailableNumber = 20000000;
        }

        /// <summary>
        /// Returns the single instance of the NextClient class.
        /// </summary>
        public static NextClient GetInstance()
        {
            if (nextClient == null)
            {
                nextClient = db.NextClients.SingleOrDefault();

                if (nextClient == null)
                {
                    nextClient = new NextClient();
                    db.NextClients.Add(nextClient);
                    db.SaveChanges();
                }
            }
            return nextClient;
        }
    }

    /// <summary>
    /// NextTransaction model. Extends the NextUniqueNumber superclass.
    /// </summary>
    public class NextTransaction : NextUniqueNumber
    {
        private static  NextTransaction nextTransaction;
        
        private NextTransaction()
        {
            this.NextAvailableNumber = 700;
        }

        /// <summary>
        /// Returns the single instance of the NextTransaction class.
        /// </summary>
        public static NextTransaction GetInstance()
        {
            if (nextTransaction == null)
            {
                nextTransaction = db.NextTransactions.SingleOrDefault();

                if (nextTransaction == null)
                {
                    nextTransaction = new NextTransaction();
                    db.NextTransactions.Add(nextTransaction);
                    db.SaveChanges();
                }
            }
            return nextTransaction;
        }
    }

    /// <summary>
    /// StoredProcedure model.
    /// </summary>
    static class StoredProcedure
    {
        public static long? NextNumber(string discriminator)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost; " + 
                    "Initial Catalog=BankOfBIT_JCContext;Integrated Security=True");
                long? returnValue = 0;
                SqlCommand storedProcedure = new SqlCommand("next_number", connection);
                storedProcedure.CommandType = CommandType.StoredProcedure;
                storedProcedure.Parameters.AddWithValue("@Discriminator", discriminator);
                SqlParameter outputParameter = new SqlParameter("@NewVal", SqlDbType.BigInt)
                {
                    Direction = ParameterDirection.Output
                };
                storedProcedure.Parameters.Add(outputParameter);
                connection.Open();
                storedProcedure.ExecuteNonQuery();
                connection.Close();
                returnValue = (long?)outputParameter.Value;
                return returnValue;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}