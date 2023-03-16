using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankOfBIT_JC.Data
{
    public class BankOfBIT_JCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BankOfBIT_JCContext() : base("name=BankOfBIT_JCContext")
        {
        }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.AccountState> AccountStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.BankAccount> BankAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.BronzeState> BronzeStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.SilverState> SilverStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.GoldState> GoldStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.PlatinumState> PlatinumStates { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.ChequingAccount> ChequingAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.SavingsAccount> SavingsAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.MortgageAccount> MortgageAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.InvestmentAccount> InvestmentAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.NextUniqueNumber> NextUniqueNumbers { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.NextSavingsAccount> NextSavingsAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.NextMortgageAccount> NextMortgageAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.NextInvestmentAccount> NextInvestmentAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.NextChequingAccount> NextChequingAccounts { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.NextTransaction> NextTransactions { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.NextClient> NextClients { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.Payee> Payees { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.Institution> Institutions { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.TransactionType> TransactionTypes { get; set; }

        public System.Data.Entity.DbSet<BankOfBIT_JC.Models.Transaction> Transactions { get; set; }
    }
}
