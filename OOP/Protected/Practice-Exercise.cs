using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string accNumber = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(accNumber, balance);

            user.ShowDetails();
        }
    }

    class Account
    {
        // Changed access modifier from private to protected
        protected double Balance { get; set; }
    }

    class User : Account
    {
        public string AccNumber { get; set; }

        // Constructor to assign values to members
        public User(string accNumber, double balance)
        {
            AccNumber = accNumber;
            Balance = balance; // Assigning the balance
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
