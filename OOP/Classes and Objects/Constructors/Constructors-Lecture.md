# Constructors 
A class constructor is a special member method of a class that is executed whenever a new object of that class is created.

A constructor has exactly the same name as its class, is public, and does not have any return type.

**For example:**
```cs
class Person
{
  private int age;
  public Person()
  {
    Console.WriteLine("Hi there");
  }
}
```
Now, upon the creation of an object of type Person, the constructor is automatically called.
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
        class Person
        {
            private int age;
            public Person()
            {
                Console.WriteLine("Hi there");
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
        }
    }
}

// OUTPUT
// Hi there
```

This can be useful in a number of situations. For example, when creating an object of type BankAccount, you could send an email notification to the owner.

The same functionality could be achieved using a separate public method. The advantage of the constructor is that it is called automatically.

Constructors can be very useful for setting initial values for certain member variables.

A default constructor has no parameters. However, when needed, parameters can be added to a constructor. This makes it possible to assign an initial value to an object when it's created, as shown in the following example:

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
        class Person
        {
            private int age;
            private string name;
            public Person(string nm)
            {
                name = nm;
            }
            public string getName()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("David");
            Console.WriteLine(p.getName());
        }
    }
}
// OUTPUT
// David
```
Now, when the object is created, we can pass a parameter that will be assigned to the **name** variable.

> Constructors can be **overloaded** like any method by using different numbers of parameters.