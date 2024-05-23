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
        public static Score operator+(Score a, Score b) {
            int r1 = a.round1Score + b.round1Score;
            int r2 = a.round2Score + b.round2Score;
            Score res = new Score(r1, r2);
            return res;
        }
    }

        static void Main(string[] args)
        {
            Score tm1 = new Score(2, 3);
            Score tm2 = new Score(4, 2);

            Score finalScores = tm1 + tm2;


            Console.WriteLine("Round 1: " + finalScores.round1Score);
            Console.WriteLine("Round 2: " + finalScores.round2Score);
        }
    }
}