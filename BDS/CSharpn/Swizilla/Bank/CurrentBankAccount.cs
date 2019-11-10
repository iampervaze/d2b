using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.Bank
{
    public class CurrentBankAccount : BankAccount
    {
        public CurrentBankAccount(int _accountNumber, string _holdersName, decimal _balance) : base(_accountNumber, _holdersName, _balance)
        {

        }

        public override string ToString()
        {
            return "Account Type: " + "Current, " + base.ToString();
        }

        public override decimal Withdraw(decimal amount)
        {
            if (balance - amount < 0)
                throw new Exception("Insufficient Balance Exception");
            balance -= amount;
            return balance;
        }
    }
}
