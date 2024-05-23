# PRACTICE EXERCISE : Operator Overloading

You and your friend are playing a game as one team. Each player must pass 2 rounds and gets points for each round passed.

The program you are given creates two Score objects where each round scores are stored (they are passed to a constructor).

Overload the + operator for the Score class to calculate the team score for every round.

> Remember to use **operator** keyword while operator overloading.

```cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {

        static void Main(string[] args)
        {
            Score tm1 = new Score(2, 3);
            Score tm2 = new Score(4, 2);

            Score finalScores = tm1 + tm2;


            Console.WriteLine("Round 1: " + finalScores.round1Score);
            Console.WriteLine("Round 2: " + finalScores.round2Score);
        }
    }
    class Score
    {
        public int round1Score { get; set; }
        public int round2Score { get; set; }
        public Score(int r1, int r2)
        {
            round1Score = r1;
            round2Score = r2;
        }
        
        //your code goes here
    }
}
```