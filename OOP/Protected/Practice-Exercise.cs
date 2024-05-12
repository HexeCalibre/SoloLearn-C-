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
        private double Balance { get; set; }
    }

    class User : Account
    {
        public string AccNumber { get; set; }
        
        //complete the constructor
        public User(string accNumber, double balance)
        {
            
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}