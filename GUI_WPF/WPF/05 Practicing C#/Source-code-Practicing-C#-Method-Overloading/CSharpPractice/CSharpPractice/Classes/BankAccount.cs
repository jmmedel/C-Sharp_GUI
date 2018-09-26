using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Classes
{
    public class BankAccount
    {
        private double balance;
        public double Balance
        {
            get
            {
                if (balance < 1000000)
                    return balance;
                return 1000000;
            }

            protected set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public BankAccount()
        {
            Balance = 100;
        }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public double AddToBalance(double balaceToBeAdded)
        {
            Balance += balaceToBeAdded;
            return Balance;
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 10;
        }
    }
}
