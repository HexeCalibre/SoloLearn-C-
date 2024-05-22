# PRACTICE EXERCISE : Destructors 

Five participants have advanced to the final round of a TV trivia show, and it is time to announce the winner and end the game.

The program you are given defines the array of finalists, takes the index of the winner as input, and creates the FinalRound object.

Complete the FinalRound class by writing the needed code in constructor to take the array and the winner index as parameters and output the corresponding message to show the winner. Then create a destructor to finish the game and output "Game Over".

**Sample Input**
2

**Sample Output**
Winner is Leyla Brown
Game Over

> Use ~ and the class name to create the destructor.

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };

            int winner = Convert.ToInt32(Console.ReadLine());

            //this should show the winner and "Game Over"
            FinalRound finalRound = new FinalRound(finalists, winner);
        }
    }

    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            //complete the constructor
            Console.WriteLine("Winner is " + );
        }
        
        //create destructor => "Game Over"
        
    }
}
```