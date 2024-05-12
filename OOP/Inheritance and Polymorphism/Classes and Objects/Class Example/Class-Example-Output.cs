# using System;
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
            //create a Welcome object with the same name
            Welcome welcome = new Welcome();


            welcome.WelcomeMessage();
        }
    }

    class Welcome
    {
        //complete the class, add WelcomeMessage() method
        public void WelcomeMessage()
        {
            Console.Write("Welcome to OOP");
        }

    }
}