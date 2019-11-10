using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class Account
    {
        public enum Type { SavingsAccount, CurrentAccount }

        public Type AccountType { get; }
        public int AccountNumber { get; }
        public string HoldersName { get; }
        
        public decimal Balance { private get; set; }
        

        public Account(Type accountType, int accountNumber, string holdersName, decimal balance)
        {
            AccountType = accountType;
            AccountNumber = accountNumber;
            HoldersName = holdersName;
            Balance = balance;
        }

        public override string ToString()
        {
            return
                "{" +
                "Account Type: " + AccountType + ", " +
                "Account Number: " + AccountNumber + ", " +
                "Holder's Name: " + HoldersName + ", " +
                "Balance: " + Balance.ToString("N") +
                "}";

        }

        public decimal Withdraw(decimal amount)
        {
            switch (AccountType)
            {
                case Type.SavingsAccount:
                    // SavingsAccount needs to maintain minimum balance
                    if (Balance - amount < 500)
                        throw new Exception("Insufficient Balance Exception");
                    Balance -= amount;
                    break;

                case Type.CurrentAccount:
                    // CurrentAccount can be 0 balance, but check amount
                    if (Balance - amount < 0)
                        throw new Exception("Insufficient Balance Exception");
                    Balance -= amount;
                    break;
            }
            return Balance;
        }

        public decimal Deposit(decimal amount)
        {
            switch (AccountType)
            {
                case Type.SavingsAccount:
                case Type.CurrentAccount:
                    // Add the amount to balance
                    Balance += amount;
                    break;
            }
            return Balance;
        }

    }
}

