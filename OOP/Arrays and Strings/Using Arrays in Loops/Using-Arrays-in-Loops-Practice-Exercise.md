# PRACTICE EXERCISE : Using Arrays in Loops 

The program you are given takes 5 numbers as input and stores them in an array.

Complete the program to go through the array and output the the sum of even numbers.

**Sample Input**
10
890
15
3699
14

**Sample Output**
914

**Hint**
An integer is even if it is divisible by two, so it means that n number is even if n%2 equals 0.

> You need to declare a **separate variable** to store the sum in it.

```cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int count = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //your code goes here
            
        }
    }
}
```