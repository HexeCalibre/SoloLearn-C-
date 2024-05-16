# Arrays Properties 

The Array class in C# provides various properties and methods to work with arrays. 

For example, the **Length** and **Rank** properties return the number of elements and the number of dimensions of the array, respectively. You can access them using the dot syntax, just like any class members:

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
            int[ ] arr = {2, 4, 7};
            
            Console.WriteLine(arr.Length); 
            
            Console.WriteLine(arr.Rank); 
        }
    }
}
// OUTPUT
/* 
3
1
*/
```

The **Length** property can be useful in **for** loops where you need to specify the number of times the loop should run.

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
        static void Main(string[] args)
        {
            int[ ] arr = {2, 4, 7};
            
            Console.WriteLine(arr.Length); 
            
            Console.WriteLine(arr.Rank); 
        }
    }
}
// OUTPUT
/*
3
1
*/
```

---

# Array Methods

There are a number of methods available for arrays.
**Max** returns the largest value.
**Min** returns the smallest value.
**Sum** returns the sum of all elements.
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
        static void Main(string[] args)
        {
            int[ ] arr = { 2, 4, 7, 1};
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());
        }
    }
}
// OUTPUT
/*
7
1
14
*/
```

> # also provides a static Array class with additional methods. You will learn about those in the next module.