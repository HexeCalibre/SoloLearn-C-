# PRACTICE EXERCISE : Indexers 
The music app you enjoy allows you to choose 5 music genres to follow.

The program you are given takes 5 music genres as input and stores them in the MusicGenres object as an array.

Fix the program by declaring an indexer inside the MusicGenres class so that the given outputs work correctly.

**Sample Input**
Blues
Rock
Hip Hop
Country
Soul

**Sample Output**
Following: Blues
Following: Rock
Following: Hip Hop
Following: Country
Following: Soul

> Remember to use this keyword for declaration of indexer.

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
        
    }
}
```