using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDeps = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            Console.WriteLine("Number of departments: " + Department.depCount);
        }
    }

    class Department
    {
        public string depName;

        // Declare static depCount member with initial value of 2
        public static int depCount = 2;

        // Complete the constructor
        public Department(string name)
        {
            // Increment the static depCount
            depCount++;

            // Output the department opened message
            Console.WriteLine("Department opened: " + name);

            // Assign the department name to the instance variable
            this.depName = name;
        }
    }
}
