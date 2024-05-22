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
    private string[] finalists;
    private int winner;

    public FinalRound(string[] finalists, int winner)
    {
        this.finalists = finalists;
        this.winner = winner;

        Console.WriteLine("Winner is " + finalists[winner]);
    }

    // Destructor
    ~FinalRound()
    {
        Console.WriteLine("Game Over");
    }
}
}