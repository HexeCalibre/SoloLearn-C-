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
            //your code goes here:
            int[] inputs = new int[5];

            // Taking input
            for (int i = 0; i < 5; i++)
            {
                inputs[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Finding max and min
            int max = inputs[0];
            int min = inputs[0];

            foreach (int num in inputs)
            {
                if (num > max)
                    max = num;

                if (num < min)
                    min = num;
            }

            // Outputting sum of max and min
            Console.WriteLine(max + min);
        }
    }
}
