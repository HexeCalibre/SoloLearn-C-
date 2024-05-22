# Static

Now it's time to discuss the **static** keyword.
You first noticed it in the Main method's declaration: 

```cs
static void Main(string[] args)
```

Class members (variables, properties, methods) can also be declared as **static**. This makes those members belong to the class itself, instead of belonging to individual objects. No matter how many objects of the class are created, there is only **one** copy of the static member.

**For example:**

```cs
class Cat {
  public static int count=0;
  public Cat() {
    count++;
  }
}
```

In this case, we declared a public member variable **count**, which is **static**. The constructor of the class increments the **count** variable by one.

> No matter how many **Cat** objects are instantiated, there is always only one **count** variable that belongs to the **Cat** class because it was declared **static**.

Because of their global nature, static members can be accessed directly using the **class name** without an object.

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
        class Cat {
            public static int count=0;
            public Cat() {
                count++;
            }
        }
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
        }
    }
}
// OUTPUT
// 2
```

As you can see, we can access the static variable using the class name: **Cat.count.**

The **count** variable is shared between all Cat objects. For this class, each time an object is created, the static value is incremented. The program above demonstrates this when 2 is displayed after creating two objects of that class.

> You must access **static** members using the class name. If you try to access them via an object of that class, you will generate an error.

To assign the value of the Math class static PI variable to x.
```cs
double x = Math.PI;
```

The same concept applies to **static** methods. 
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
            public static void Bark() {
                Console.WriteLine("Woof");
            }
        }
        static void Main(string[] args)
        {
            Dog.Bark();
        }
    }
}
// OUTPUT
// Woof
```

Static methods can access **only** static members.

> The Main method is **static**, as it is the starting point of any program. Therefore any method called directly from Main had to be **static**.

**Constant** members are static by definition.
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
        class MathClass {
            public const int ONE = 1;
        }
        static void Main(string[] args)
        {
            Console.Write(MathClass.ONE);
        }
    }
}
// OUTPUT
// 1
```
As you can see, we access the property **ONE** using the name of the class, just like a static member. This is because all **const** members are **static** by default.

**Static Constructors** 
Constructors can be declared **static** to initialize static members of the class.
The static constructor is automatically called once when we access a static member of the class.
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
        class MathClass {
            public const int ONE = 1;
        }
        static void Main(string[] args)
        {
            Console.Write(MathClass.ONE);
        }
    }
}
// OUTPUT
// 1
```

> The constructor will get called once when we try to access SomeClass.X or SomeClass.Y.

To initialize the static Age property of the Person class using a static constructor:
```cs
class Person {
    public static int Age { get; set; }
    static Person() {
        Age = 0;
    }
}
```