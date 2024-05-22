# Destructors

As constructors are used when a class is instantiated, **destructors** are automatically invoked when an object is destroyed or deleted. 

Destructors have the following attributes:

- A class can only have **one** destructor.

- Destructors cannot be called. They are invoked automatically.

- A destructor does not take modifiers or have parameters. 

- The name of a destructor is exactly the same as the class prefixed with a **tilde (~).**

**For Example:**
```cs
class Dog
{
  ~Dog() 
  {
    // code statements
  }
}
```

> Destructors can be very useful for releasing resources before coming out of the program. This can include closing files, releasing memory, and so on.

Let’s include WriteLine statements in the destructor and constructor of our class and see how the program behaves when an object of that class is created and when the program ends: 

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
        class Dog
        {
            public Dog() {
                Console.WriteLine("Constructor");
            }
            ~Dog() {
                Console.WriteLine("Destructor");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
        }
    }
}
// OUTPUT
// Constructor
// Destructor
```
When the program runs, it first creates the object, which calls the constructor. The object is deleted at the end of the program and the destructor is invoked when the program's execution is complete.

> This can be useful, for example, if your class is working with storage or files. The constructor would initialize and open the files. Then, when the program ends, the destructor would close the files.

