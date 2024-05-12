# PRACTICE EXERCISE : Card Numbers 

The program you are given should output the account number on the bank card.

But something is wrong.

Create a get property to access the corresponding class member and also fix the output.

> In order to execute the output you should pass **the property** to Console.WriteLine() method.

```cs
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
            Card card1 = new Card();

            //fix the output
            Console.WriteLine(card1.accountNum);
        }
    }
    class Card
    {
        private string accountNum = "0011592048120";
        //create a property to get the account
        
    }
}
```