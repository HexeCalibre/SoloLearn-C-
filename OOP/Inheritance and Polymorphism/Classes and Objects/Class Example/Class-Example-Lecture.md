# Example of a Class 

Let’s create a Person class: 

```cs
class Person
{
  int age;
  string name;
  public void SayHi()
  {
    Console.WriteLine("Hi");
  }
}
```
The code above declares a class named **Person**, which has **age** and **name** fields as well as a **SayHi** method that displays a greeting to the screen.

You can include an **access modifier** for fields and methods (also called **members**) of a class. Access modifiers are keywords used to specify the accessibility of a member.

A member that has been defined **public** can be accessed from outside the class, as long as it's anywhere within the scope of the class object. That is why our **SayHi** method is declared **public**, as we are going to call it from outside of the class.

> You can also designate class members as **private** or **protected**. This will be discussed in greater detail later in the course. If no access modifier is defined, the member is **private** by default.

To create a class called Car.
```cs
class Car {
    string color;
    int year;
}
```
Now that we have our Person class defined, we can instantiate an object of that type in Main.

The **new** operator instantiates an object and returns a reference to its location:

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
        class Person {
            int age;
            string name;
            public void SayHi() {
                Console.WriteLine("Hi");
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();
        }
    }
}
```

The code above declares a Person object named **p1** and then calls its public **SayHi**() method.

Notice the **dot operator (.)** that is used to access and call the method of the object.

To create an object of type Car and call its horn() method.
```cs
Car c = new Car();
c.horn();
```

You can access all public members of a class using the dot operator. 

Besides calling a method, you can use the dot operator to make an assignment when valid. 

**For example:**
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
            public string name;
            public int age;
        }
        static void Main(string[] args)
        {
            Dog bob = new Dog();
            bob.name = "Bobby";
            bob.age = 3;
            
            Console.WriteLine(bob.age);
        }
    }
}
```
