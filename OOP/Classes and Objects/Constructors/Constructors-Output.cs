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
            Project project = new Project();

            project.Create();
        }
    }
    class Project
    {
        //create a constructor to show "Project created"
        public void Create()
        {
            Console.Write("Project created");
        }

    }
}