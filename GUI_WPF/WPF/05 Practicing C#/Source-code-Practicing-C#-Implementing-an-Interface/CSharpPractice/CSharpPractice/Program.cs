using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Classes;
using CSharpPractice.Interfaces;

namespace CSharpPractice
{
    class Program
    {
        static double numberTwo = 12.34;
        static void Main(string[] args)
        {
            ChildBankAccount bankAccount = new ChildBankAccount();
            bankAccount.AddToBalance(100);

            SimpleMath simpleMath = new SimpleMath();

            Console.WriteLine(Information(bankAccount));

            Console.ReadLine();
        }

        private static string Information(IInformation information)
        {
            return information.GetInformation();
        }
    }

    class SimpleMath : IInformation
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Add(double[] numbers)
        {
            double result = 0;
            foreach(double d in numbers)
            {
                result += d;
            }

            return result;
        }

        public string GetInformation()
        {
            return "Class that solves simple math.";
        }
    }
}
