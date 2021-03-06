﻿using System;
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

            private set
            {
                if (value > 0)
                    balance = value;
                balance = 0;
            }
        }

        public double AddToBalance(double balaceToBeAdded)
        {
            Balance += balaceToBeAdded;
            return Balance;
        }
    }
}
