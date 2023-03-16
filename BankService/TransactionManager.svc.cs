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
        /// This method updates the balance of a bank account with the specified amount and
        /// returns the updated balance.
        /// </summary>
        /// <param name = "accountId" > The ID of the bank account.</param>
        /// <param name = "amount" > The amount to be deposited or withdrawn.</param>
        /// <returns>
        /// Returns the updated balance of the bank account. If the balance cannot be updated, returns null.
        /// </returns>
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
        /// Creates a new transaction object and adds it to the Transactions database table.
        /// The transaction object is populated with the given account ID, amount, transaction type ID, and notes.
        /// If the amount is negative, the transaction object is marked as a withdrawal with a null deposit value,
        /// and if the amount is positive, it is marked as a deposit with a null withdrawal value.
        /// The transaction number is set to the next available number and the transaction is saved to the database.
        /// </summary>
        /// <param name="accountId">The ID of the bank account associated with the transaction.</param>
        /// <param name="amount">The amount of the transaction.</param>
        /// <param name="transactionTypeId">The ID of the transaction type (deposit, withdrawal, etc.)</param>
        /// <param name="notes">Any notes related to the transaction.</param>
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

        /// <summary>
        /// Deposits a specified amount of money into the specified bank account.
        /// </summary>
        /// <param name="accountId">The ID of the bank account to deposit the money into.</param>
        /// <param name="amount">The amount of money to deposit.</param>
        /// <param name="notes">Additional notes or information about the deposit.</param>
        /// <returns>
        /// Returns the updated account balance after the deposit has been made.
        /// Returns null if the account does not exist or the amount is negative.
        /// </returns>
        public double? Deposit(int accountId, double amount, string notes)
        {
            try
            {
                BankAccount bankAccount = db.BankAccounts.Find(accountId);

                if (bankAccount == null)
                {
                    throw new Exception();
                }

                if (amount < 0)
                {
                    throw new Exception();
                }

                else
                {
                    CreateTransaction(accountId, amount, 1, notes);
                    double? updatedBalance = UpdateBalance(accountId, amount);
                    return updatedBalance;
                }
            }

            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Withdraws the specified amount from the specified account, creating a transaction and updating
        /// the balance. If the account ID is invalid or the amount is negative, returns null.
        /// </summary>
        /// <param name="accountId">The ID of the account to withdraw from.</param>
        /// <param name="amount">The amount to withdraw.</param>
        /// <param name="notes">Notes to attach to the transaction.</param>
        /// <returns>The updated balance of the account, or null if the withdrawal was unsuccessful.</returns>
        public double? Withdrawal(int accountId, double amount, string notes)
        {
            try
            {
                BankAccount bankAccount = db.BankAccounts.Find(accountId);

                double withdrawalAmount = amount * -1;

                if (bankAccount == null)
                {
                    throw new Exception();
                }

                if (amount < 0)
                {
                    throw new Exception();
                }

                else
                {
                    CreateTransaction(accountId, withdrawalAmount, 2, notes);
                    double? updatedBalance = UpdateBalance(accountId, withdrawalAmount);
                    return updatedBalance;
                }
            }

            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Handles a bill payment for a specified bank account.
        /// </summary>
        /// <param name="accountId">The ID of the bank account to make the payment from.</param>
        /// <param name="amount">The amount of the bill payment.</param>
        /// <param name="notes">Additional notes to be associated with the bill payment transaction.</param>
        /// <returns>A nullable double representing the updated balance of the bank
        /// account after the payment is made. Returns null if there is an error.</returns>
        /// <exception cref="Exception">Thrown if the bank account with the specified ID
        /// cannot be found or if the amount is negative.</exception>
        public double? BillPayment(int accountId, double amount, string notes)
        {
            try
            {
                BankAccount bankAccount = db.BankAccounts.Find(accountId);

                double paymentAmount = amount * -1;

                if (bankAccount == null)
                {
                    throw new Exception();
                }

                if (amount < 0)
                {
                    throw new Exception();
                }

                else
                {
                    CreateTransaction(accountId, paymentAmount, 3, notes);
                    double? updatedBalance = UpdateBalance(accountId, paymentAmount);
                    return updatedBalance;
                }
            }

            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Transfers a specified amount of money from one bank account to another.
        /// </summary>
        /// <param name="fromAccountId">The ID of the bank account to transfer the money from.</param>
        /// <param name="toAccountId">The ID of the bank account to transfer the money to.</param>
        /// <param name="amount">The amount of money to transfer.</param>
        /// <param name="notes">Additional notes to be associated with the transaction.</param>
        /// <returns>A nullable double representing the updated balance of the bank
        /// account from which the money was transferred. Returns null if there is an error.</returns>
        /// <exception cref="Exception">Thrown if either of the bank accounts with the specified
        /// IDs cannot be found or if the amount is negative.</exception>
        public double? Transfer(int fromAccountId, int toAccountId, double amount, string notes)
        {
            try
            {
                BankAccount fromBankAccount = db.BankAccounts.Find(fromAccountId);
                BankAccount toBankAccount = db.BankAccounts.Find(toAccountId);

                double withdrawalAmount = amount * -1;

                if (fromBankAccount == null || toBankAccount == null)
                {
                    throw new Exception();
                }

                if (amount < 0)
                {
                    throw new Exception();
                }

                else
                {
                    CreateTransaction(fromAccountId, withdrawalAmount, 4, notes);
                    double? updatedBalance = UpdateBalance(fromAccountId, withdrawalAmount);

                    CreateTransaction(toAccountId, amount, 5, notes);
                    UpdateBalance(toAccountId, amount);

                    return updatedBalance;
                }
            }

            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Calculates and records interest for a specified bank account based on its balance and interest rate.
        /// </summary>
        /// <param name="accountId">The ID of the bank account to calculate interest for.</param>
        /// <param name="notes">Additional notes to be associated with the interest transaction.</param>
        /// <returns>A nullable double representing the updated balance of the bank account after the interest is calculated and recorded. Returns null if there is an error.</returns>
        /// <exception cref="Exception">Thrown if the bank account with the specified ID cannot be found.</exception>
        public double? CalculateInterest(int accountId, string notes)
        {
            try
            {
                BankAccount bankAccount = db.BankAccounts.Find(accountId);
                AccountState accountState = db.AccountStates.Find(accountId);

                if (bankAccount == null)
                {
                    throw new Exception();
                }

                double interestRate = accountState.RateAdjustment(bankAccount);
                double interest = (interestRate * bankAccount.Balance * 1) / 12;

                CreateTransaction(accountId, interest, 6, notes);
                double? updatedBalance = UpdateBalance(accountId, interest);

                return updatedBalance;
            }

            catch (Exception)
            {
                return null;
            }
        }
    }
}
