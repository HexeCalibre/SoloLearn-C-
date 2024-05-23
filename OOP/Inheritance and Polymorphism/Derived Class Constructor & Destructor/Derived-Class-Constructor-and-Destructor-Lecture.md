# Inheritance
Constructors are called when objects of a class are created. With inheritance, the base class constructor and destructor are not inherited, so you should define constructors for the derived classes.

However, the base class constructor and destructor are being invoked automatically when an object of the derived class is created or deleted. 

**Consider the following example:**

```cs
class Animal {
  public Animal() {
    Console.WriteLine("Animal created");
  }
  ~Animal() {
    Console.WriteLine("Animal deleted");
  }
}
class Dog: Animal {
  public Dog() {
    Console.WriteLine("Dog created");
  }
  ~Dog() {
    Console.WriteLine("Dog deleted");
  }
}
```
We have defined the Animal class with a constructor and destructor and a derived Dog class with its own constructor and destructor.

> So what will happen when we create an object of the derived class? Tap next to find out!

Let's create a Dog object: 

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
        class Animal {
            public Animal() {
                Console.WriteLine("Animal created");
            }
            ~Animal() {
                Console.WriteLine("Animal deleted");
            }
        }
        class Dog: Animal {
            public Dog() {
                Console.WriteLine("Dog created");
            }
            ~Dog() {
                Console.WriteLine("Dog deleted");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
        }
    }
}
// OUTPUT
/*
Animal created
Dog created
Dog deleted
Animal deleted
*/
```

Note that the base class constructor is called first and the derived class constructor is called next.

When the object is destroyed, the derived class destructor is invoked and then the base class destructor is invoked.

> You can think of it as the following: The derived class needs its base class in order to work, which is why the base class constructor is called first.