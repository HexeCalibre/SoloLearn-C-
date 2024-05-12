# PRACTICE EXERCISE : Encapsulation

We are developing a profile system for player of our online game.

The program already takes the number of games and wins as input and creates a player object.

Complete the GetWinRate() method inside the given Player class to calculate and output the win rate.

**Sample Input**
130
70

**Sample Output**
53

**Explanation**
Win rate is calculated by this formula: wins*100/games. So, in this case win rate is 70*100/130 = 53 (the final result should be an integer).

> Notice that you should execute the **output** of the win rate inside the method.

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
            int games = Convert.ToInt32(Console.ReadLine()); 
            int wins = Convert.ToInt32(Console.ReadLine()); 

            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();
        }
    }
    
    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //complete the method
        public void GetWinRate()
        {
            
        }
    }
}
```
To declare a Person class, hide the age member, and make it accessible through the GetAge method.

```cs
class Person {
    private int age;
    public int GetAge() {
        return age;
    }
    public void SetAge(int n) {
        age = n;
    }
}
```
