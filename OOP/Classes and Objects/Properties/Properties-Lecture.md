# Properties 

As we have seen in the previous lessons, it is a good practice to encapsulate members of a class and provide access to them only through public methods.

A **property** is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they are public data members, but they actually include special methods called **accessors**.

The accessor of a property contains the executable statements that help in getting (reading or computing) or setting (writing) a corresponding field. Accessor declarations can include a **get** accessor, a **set** accessor, or both. 

**For example:**

```cs
class Person
{
  private string name; //field

  public string Name //property
  {
    get { return name; }
    set { name = value; }
  }
}
```

The Person class has a **Name** property that has both the **set** and the **get** accessors.

The set accessor is used to assign a value to the name variable; get is used to return its value.

>value is a special keyword, which represents the value we assign to a property using the set accessor.
>The name of the property can be anything you want, but coding conventions dictate properties have the same name as the private field with a capital letter.

Once the property is defined, we can use it to assign and read the private member: 

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
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine(p.Name);
        }
    }
}
// OUTPUT
// 
```

> The property is accessed by its name, just like any other public member of the class.

To define valid get and set accessors for the age member:

```cs
class Dog
{
    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}
```

Any accessor of a property can be omitted. 

For example, the following code creates a property that is read-only: 

```cs
class Person
{
  private string name;
  public string Name
  {
    get { return name; }
  }
}
```

>  A property can also be **private**, so it can be called only from within the class.

So, why use properties? Why not just declare the member variable public and access it directly?

With properties you have the option to control the logic of accessing the variable. 

For example, you can check if the value of **age** is greater than 0, before assigning it to the variable: 

```cs
class Person
{
  private int age=0;
  public int Age
  {
    get { return age; }
    set {
      if (value > 0)
        age = value;
    }
  }
}
```

> You can have any custom logic with **get** and **set** accessors.

To create a read-only property X. The return value of the accessor should be the square of x.

```cs
class A {
  private int x = 8;
  public int X {
    get { return x * x; }
  }
}
```
---

# Auto-Implemented Properties

When you do not need any custom logic, C# provides a fast and effective mechanism for declaring private members through their properties.

For example, to create a private member that can only be accessed through the **Name** property's **get** and **set** accessors, use the following syntax: 

```cs
public string Name { get; set; }
```
As you can see, you do not need to declare the private field name separately - it is created by the property automatically. **Name** is called an **auto-implemented property**. Also called auto-properties, they allow for easy and short declaration of private members.

We can rewrite the code from our previous example using an auto-property:

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
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine(p.Name);
        }
    }
}
// OUTPUT
// Bob
```
To create an auto-property named Age of type int.

```cs
class Dog
{
  public int Age { get; set; }
}
```
