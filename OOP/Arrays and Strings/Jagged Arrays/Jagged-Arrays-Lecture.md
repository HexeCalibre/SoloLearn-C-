# Jagged Arrays 

A **jagged array** is an array whose elements are arrays. So it is basically an **array of arrays**.

The following is a declaration of a single-dimensional array that has three elements, each of which is a single-dimensional array of integers:

```cs
int[ ][ ] jaggedArr = new int[3][ ];
```
Each dimension is an array, so you can also initialize the array upon declaration like this:
```cs
int[ ][ ] jaggedArr = new int[ ][ ] 
{
  new int[ ] {1,8,2,7,9},
  new int[ ] {2,4,6},
  new int[ ] {33,42}
};
```
You can access individual array elements as shown in the example below:

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
            int[ ][ ] jaggedArr = new int[ ][ ] 
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}
            };
            int x = jaggedArr[2][1];
            Console.WriteLine(x);
        }
    }
}
// OUTPUT
// 42
```
This accesses the second element of the third array.
> A **jagged array** is an array-of-arrays, so an int[ ][ ] is an array of int[ ], each of which can be of different lengths and occupy their own block in memory.
> A **multidimensional array** (int[,]) is a single block of memory (essentially a matrix). It always has the same amount of columns for every row.

To declare a jagged array that contains 8 two-dimensional arrays.

```cs
int[ ][ , ] a = new int[8][ , ];
```
