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
            MusicGenres genres = new MusicGenres();

            int count = 0;
            while (count<5)
            {
                genres[count] = Console.ReadLine();
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Following: " + genres[i]);
            }
        }
    }
    class MusicGenres
    {
        private string[] genres = new string[5];
        
        //declare an indexer
        public string this[int index] {
            get {
                return genres[index];
            }
            set {
                genres[index] = value;
            }
        }
        
    }
}