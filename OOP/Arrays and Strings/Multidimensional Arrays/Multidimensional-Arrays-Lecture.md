# Multidimensional Arrays

An array can have multiple dimensions. A **multidimensional** array is declared as follows:

```cs
type[, , … ,] arrayName = new type[size1, size2, …, sizeN];
```
For example, let's define a two-dimensional 3x4 integer array:
```cs
int[ , ] x = new int[3,4];
```
Visualize this array as a table composed of 3 rows and 4 columns:
![](/img/multidimensional%20array.jpg)
> Array indexing starts from 0.

To declare a two-dimensional array of integers with 8 rows and 8 columns.

```cs
int[ , ] chessBoard = new int[8, 8];
 ```

 We can initialize multidimensional arrays in the same way as single-dimensional arrays.

**For example:**
```cs
int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} };
```
This will create an array with three rows and two columns. Nested curly brackets are used to define values for each row.

To access an element of the array, provide both indexes. For example **someNums[2, 0]** will return the value **4**, as it accesses the first column of the third row.

Let's create a program that will display the values of the array in the form of a table.

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
            int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} }; 
            for (int k = 0; k < 3; k++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(someNums[k, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
// OUTPUT
/*
2 3
5 6
4 6
*/
```
We have used two nested **for** loops, one to iterate through the rows and one through the columns.

The Console.WriteLine(); statement moves the output to a new line after one row is printed.

> Arrays can have any number of dimensions, but keep in mind that arrays with more than three dimensions are harder to manage.