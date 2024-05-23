# Protected

Up to this point, we have worked exclusively with **public** and **private** access modifiers.

Public members may be accessed from anywhere outside of the class, while access to private members is limited to their class. 

The **protected** access modifier is very similar to **private** with one difference; it can be accessed in the derived classes. So, a **protected** member is accessible only from derived classes.

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
            protected int Age {get; set;}
            protected string Name {get; set;}
        }
        class Student : Person {
            public Student(string nm) {
                Name = nm;
            }
            public void Speak() {
                Console.Write("Name: "+Name);
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("David");
            s.Speak();
        }
    }
}
// OUTPUT
// Name: David
```

As you can see, we can access and modify the Name property of the base class from the derived class.

But, if we try to access it from outside code, we will get an error:

To make the Area method of the Shape class accessible only in the derived class:
```cs
class Shape {
    public int H {get;set;}
    public int W {get;set;}
    protected int Area() {
        return H * W;
    }
}
```
---
## Sealed

A class can prevent other classes from inheriting it, or any of its members, by using the **sealed** modifier.

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
        sealed class Animal {
            //some code
        }
        class Dog : Animal { } //Error
        
        static void Main(string[] args)
        {
            
        }
    }
}

// OUTPUT
// file0.cs(14,21): error CS0509: 'Program.Dog': cannot derive from sealed type 'Program.Animal'
```

In this case, we cannot derive the Dog class from the Animal class because Animal is **sealed**.

> The **sealed** keyword provides a level of protection to your class so that other classes cannot inherit from it.

To derive a class B from class A and prevent class B from being inherited.

```cs
class A {

}
sealed class B : A {

}
```
