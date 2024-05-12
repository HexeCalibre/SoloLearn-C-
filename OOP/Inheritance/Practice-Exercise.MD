# Practice Exercise: Inheritance

## Objective
🎯 The objective of this exercise is to practice inheritance in object-oriented programming by completing the implementation of a Car class that inherits from a Vehicle class.

## Task
🛠️ The program provided takes the brand and model of a car as input and defines a Vehicle class with a model property and ShowModel() method. Your task is to complete the Car class so that it inherits from the Vehicle class and adds the Model property and ShowModel() method.

## Instructions
1. Open the provided program file.
2. Complete the Car class to inherit from the Vehicle class.
3. Add the Model property and ShowModel() method to the Car class.
4. Ensure that the ShowModel() method correctly displays the model of the car.
5. Test the program with the provided sample input and verify that the output matches the sample output.

## Sample Input

```shell
🚗 BMW
5 Series
```

## Sample Output
```shell
🏷️ Brand: BMW
📄 Model: 5 Series
```

## File Structure
- `Program.cs`: Contains the main program code.
- `README.md`: Instructions for the exercise.

## Note
⚠️ Do not look at the solution directly. Try to solve the exercise on your own first. If you need hints or guidance, refer to the hints provided.


---

## Practice Exercise: Derived Class Constructor & Destructor :airplane:

You are the airport administrator responsible for setting flight statuses.

At first, the flight program was showing only "Registration" and "Closed" statuses, but we need to expand it to give more detailed information.

Derive `WayStatus` class from `Flight` class and complete its:

1. Constructor, to output "On the way" :rocket:
2. Destructor, to output "Landed" :airplane_arriving:

So that the program correctly outputs all the statuses of the flight.

> Remember, that while creating derived class object the constructor and the destructor of base class also called - the constructor is called at beginning and the destructor at very end.

```cs
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
    /*derive this class from Flight class,
    define constructor and destructor for it*/
    class WayStatus
    {
        
    }
}
```
