using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.Bank
{
    public abstract class BankAccount
    {
        protected int accountNumber;
        protected string holdersName;
        protected decimal balance;

        public BankAccount(int _accountNumber, string _holdersName, decimal _balance)
        {
            accountNumber = _accountNumber;
            holdersName = _holdersName;
            balance = _balance;
        }

        public override string ToString()
        {
            return
                "Account Number: " + accountNumber + ", " +
                "Holder's Name: " + holdersName + ", " +
                "Balance: " + balance.ToString("N");

        }

        public abstract decimal Withdraw(decimal amount);

        public virtual decimal Deposit(decimal amount)
        {
            balance += amount;
            return balance;
        }
    }
}
