# Static Classes
An entire class can be declared as **static**.

A **static class** can contain only static members. 

You cannot instantiate an object of a static class, as only one instance of the static class can exist in a program.

Static classes are useful for combining logical properties and methods. A good example of this is the **Math** class.

It contains various useful properties and methods for mathematical operations. 

**For example, the Pow method raises a number to a power:**

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
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 3));
        }
    }
}
// OUTPUT
// 8
```

You access all members of the Math class using the class name, without declaring an object.

There are a number of useful static methods and properties available in C#: 

## Math

Math.**PI** the constant PI.

Math.**E** represents the natural logarithmic base e.

Math.**Max()** returns the larger of its two arguments.

Math.**Min()** returns the smaller of its two arguments.

Math.**Abs()** returns the absolute value of its argument.

Math.**Sin()** returns the sine of the specified angle.

Math.**Cos()** returns the cosine of the specified angle.

Math.**Pow()** returns a specified number raised to the specified power.

Math.**Round()** rounds the decimal number to its nearest integral value.

Math.**Sqrt()** returns the square root of a specified number.

## Array

The **Array** class includes some static methods for manipulating arrays: 

```cs
int[] arr = {1, 2, 3, 4};

Array.Reverse(arr);
//arr = {4, 3, 2, 1}

Array.Sort(arr);
//arr = {1, 2, 3, 4}
```

## String 

```cs
string s1 = "some text";
string s2 = "another text";

String.Concat(s1, s2); // combines the two strings

String.Equals(s1, s2); // returns false
```

## DateTime 

The **DateTime** structure allows you to work with dates.

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
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            
            Console.WriteLine(DateTime.DaysInMonth(2016, 2));
        }
    }
}
// OUTPUT
/*
05/22/2024 02:38:41
05/22/2024 00:00:00
29
*/
```

> The **Console** class is also an example of a static class. We use its static **WriteLine()** method to output to the screen, or the static **ReadLine()** method to get user input.
> The **Convert** class used to convert value types is also a static class.

