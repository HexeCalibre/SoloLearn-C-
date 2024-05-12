# SEALED

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
```

```cs
// OUTPUT
file0.cs(14,21): error CS0509: 'Program.Dog': cannot derive from sealed type 'Program.Animal'
```

In this case, we cannot derive the Dog class from the Animal class because Animal is **sealed**.

> he **sealed** keyword provides a level of protection to your class so that other classes cannot inherit from it.

to derive a class B from class A and prevent class B from being inherited.

```cs
class A {

}
sealed class B : A {

}
```
