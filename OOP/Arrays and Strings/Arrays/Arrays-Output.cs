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
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            //your code goes here
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.Write(games[0]);
                    break;
                case 1:
                    Console.Write(games[1]);
                    break;
                case 2:
                    Console.Write(games[2]);
                    break;
                case 3:
                    Console.Write(games[3]);
                    break;
                case 4:
                    Console.Write(games[4]);
                    break;
                default:
                    Console.Write("Invalid number");
                    break;
            }

        }
    }
}