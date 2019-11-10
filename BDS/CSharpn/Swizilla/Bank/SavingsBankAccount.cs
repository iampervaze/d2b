using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.Bank
{
    public class SavingsBankAccount : BankAccount
    {
        public SavingsBankAccount(int _accountNumber, string _holdersName, decimal _balance) : base(_accountNumber, _holdersName, _balance)
        {

        }
        public override string ToString()
        {
            return "Account Type: " + "Savings, " + base.ToString();
        }

        public override decimal Withdraw(decimal amount)
        {
            if (balance - amount < 500)
                throw new Exception("Insufficient Balance Exception");
            balance -= amount;
            return balance;
        }
    }
}
