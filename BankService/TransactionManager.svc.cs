using BankOfBIT_JC.Data;
using BankOfBIT_JC.Models;
using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;

namespace BankService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TransactionManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TransactionManager.svc or TransactionManager.svc.cs at the Solution Explorer and start debugging.
    public class TransactionManager : ITransactionManager
    {
        private BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        public void DoWork()
        {

        }
        /// <summary>
        /// Updates the balance of the specified account by the specified amount.
        /// Returns null if an exception is encountered.
        /// </summary>
        /// <param name="accountId">The account ID.</param>
        /// <param name="amount">The amount the balance is to be changed by.</param>
        /// <returns>The updated balance.</returns>
        /// <exception cref="NotImplementedException"></exception>
        private double? UpdateBalance(int accountId, double amount)
        {
            try
            {
                IQueryable<BankAccount> query =
                    from account
                    in db.BankAccounts
                    where account.BankAccountId == accountId
                    select account;

                BankAccount bankAccount = query.FirstOrDefault();

                bankAccount.Balance += amount;

                db.SaveChanges();

                return bankAccount.Balance;
            }

            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="amount"></param>
        /// <param name="transactionTypeId"></param>
        /// <param name="notes"></param>
        private void CreateTransaction(int accountId, double amount, int transactionTypeId, string notes)
        {

            Transaction transaction = new Transaction();

            if (amount < 0)
            {
                transaction.Deposit = null;
                transaction.Withdrawal = Math.Abs(amount);
            }

            else
            {
                transaction.Deposit = amount;
                transaction.Withdrawal = null;
            }

            // Sets the DateCreated property to the current date and time.
            transaction.DateCreated = DateTime.Now;

            // Sets the Notes property to the argument value.
            transaction.Notes = notes;

            // Sets the next transaction number.
            transaction.SetNextTransactionNumber();

            // Adds the transaction to the Transactions db and saves the changes.
            db.Transactions.Add(transaction);
            db.SaveChanges();
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


    }
}
