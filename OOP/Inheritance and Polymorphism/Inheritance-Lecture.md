# Inheritance 

**Inheritance** allows us to define a class based on another class. This makes creating and maintaining an application easy.

The class whose properties are inherited by another class is called the **Base** class. The class which inherits the properties is called the **Derived** class.

For example, base class **Animal** can be used to derive **Cat** and **Dog** classes.

The derived class inherits all the features from the base class, and can have its own additional features. 

![Base Class & Derived Class](/img/dc7934160dfb449d9a21c8b994d4e1b6-2465.jpg)

> Inheritance allows us to define a class based on another class.

Let's define our base class Animal: 

```cs
class Animal {
  public int Legs {get; set;}
  public int Age {get; set;}
}
```

Now we can derive class Dog from it:

```cs
class Dog : Animal {
  public Dog() {
    Legs = 4;
  }
  public void Bark() {
    Console.Write("Woof");
  }
}
```

Note the syntax for a derived class. A **colon** and the name of the **base** class follow the name of the derived class.

All public members of **Animal** become public members of **Dog**. That is why we can access the **Legs** member in the **Dog** constructor.

Now we can instantiate an object of type **Dog** and access the inherited members as well as call its own **Bark** method.

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
            public int Legs {get; set;}
            public int Age {get; set;}
        }
        class Dog : Animal {
            public Dog() {
                Legs = 4;
            }
            public void Bark() {
                Console.Write("Woof");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine(d.Legs);
            
            d.Bark();
        }
    }
}
```
A base class can have multiple derived classes. For example, a **Cat** class can inherit from **Animal**.
> Inheritance allows the derived class to reuse the code in the base class without having to rewrite it. And the derived class can be customized by adding more members. In this manner, the derived class extends the functionality of the base class.

To derive Cat from Animal:

```cs
class Cat : Animal {
    // some code
}
```

A derived class inherits all the members of the base class, including its methods. 

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
        class Person {
            public void Speak() {
                Console.WriteLine("Hi there");
            }
        }
        class Student : Person {
            int number;
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Speak();
        }
    }
}
```
We created a **Student** object and called the **Speak** method, which was declared in the base class **Person**.
> C# does not support multiple inheritance, so you cannot inherit from multiple classes
> However, you can use **interfaces** to implement multiple inheritance. You will learn more about **interfaces** in the coming lessons.

---

Constructors are called when objects of a class are created. With inheritance, the base class constructor and destructor are not inherited, so you should define constructors for the derived classes.

However, the base class constructor and destructor are being invoked automatically when an object of the derived class is created or deleted. 

Consider the following example:

```cs
class Animal {
    // Constructor of Animal class
    public Animal() {
        Console.WriteLine("Animal created"); // Output when an Animal object is created
    }

    // Finalizer (destructor) of Animal class
    ~Animal() {
        Console.WriteLine("Animal deleted"); // Output when an Animal object is deleted (destroyed by the garbage collector)
    }
}

class Dog : Animal { // Dog class inherits from Animal class
    // Constructor of Dog class
    public Dog() {
        Console.WriteLine("Dog created"); // Output when a Dog object is created
    }

    // Finalizer (destructor) of Dog class
    ~Dog() {
        Console.WriteLine("Dog deleted"); // Output when a Dog object is deleted (destroyed by the garbage collector)
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
```
Note that the base class constructor is called first and the derived class constructor is called next.

When the object is destroyed, the derived class destructor is invoked and then the base class destructor is invoked.

> You can think of it as the following: The derived class needs its base class in order to work, which is why the base class constructor is called first.

