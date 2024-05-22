using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);

            Console.WriteLine(avg.GetAvg());
        }
    }
    
    /* 
    The program you are given 
    */

    class Avg
    {
        double num1;
        double num2;
        
        // Constructor to initialize num1 and num2
        public Avg(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double GetAvg()
        {
            return (num1 + num2)/2;
        }
    }
}
