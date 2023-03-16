using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TransactionManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TransactionManager.svc or TransactionManager.svc.cs at the Solution Explorer and start debugging.
    public class TransactionManager : ITransactionManager
    {
        public void DoWork()
        {
            
        }

        public double? BillPayment(int accountId, double amount, string notes)
        {
            throw new NotImplementedException();
        }

        public double? CalculateInterest(int accountId, string notes)
        {
            throw new NotImplementedException();
        }

        public double? Deposit(int accountId, double amount, string notes)
        {
            throw new NotImplementedException();
        }

        public double? Transfer(int fromAccountId, int toAccountId, double amount, string notes)
        {
            throw new NotImplementedException();
        }

        public double? Withdrawal(int accountId, double amount, string notes)
        {
            throw new NotImplementedException();
        }

        private double? UpdateBalance(int accountId, double amount)
        {
            throw new NotImplementedException();
        }

        private void CreateTransaction(int accountId, double amount, int transactionTypeId, string notes)
        {
            throw new NotImplementedException();
        }
    }
}
