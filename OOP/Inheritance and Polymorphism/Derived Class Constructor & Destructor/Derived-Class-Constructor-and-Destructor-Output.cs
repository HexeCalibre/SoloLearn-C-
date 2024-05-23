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
            WayStatus status = new WayStatus();
        }
    }

    class Flight
    {
        public Flight()
        {
            Console.WriteLine("Registration");
        }

        ~Flight()
        {
            Console.WriteLine("Closed");
        }
    }

    // Derived class WayStatus from Flight
    class WayStatus : Flight
    {
        // Constructor to output "On the way"
        public WayStatus()
        {
            Console.WriteLine("On the way");
        }

        // Destructor to output "Landed"
        ~WayStatus()
        {
            Console.WriteLine("Landed");
        }
    }
}
