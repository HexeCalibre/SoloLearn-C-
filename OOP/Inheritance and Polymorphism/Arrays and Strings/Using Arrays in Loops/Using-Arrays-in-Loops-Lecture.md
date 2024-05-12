# Arrays & Loops

It's occasionally necessary to iterate through the elements of an array, making element assignments based on certain calculations. This can be easily done using loops.

For example, you can declare an array of 10 integers and assign each element an even value with the following loop: 

```cs
int[ ] a = new int[10];
for (int k = 0; k < 10; k++) {
  a[k] = k*2;
}
```
We can also use a loop to read the values of an array.

For example, we can display the contents of the array we just created:
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
            int[ ] a = new int[10];
            for (int k = 0; k < 10; k++) {
                a[k] = k*2;
            }
            for (int k = 0; k < 10; k++) {
                Console.WriteLine(a[k]);
            }
        }
    }
}
// OUTPUT
/*
 0
2
4
6
8
10
12
14
16
18
*/
```
This will display the values of the elements of the array.
> The variable k is used to access each array element.
> The last index in the array is 9, so the for loop condition is k<10.

To print all elements of the array using a for loop.
```cs
int[ ] arr = new int[7];
for (int k = 0; k < 7; k++) {
    Console.WriteLine( arr [k]);
}
```
---
# The foreach Loop

The **foreach** loop provides a shorter and easier way of accessing array elements.

The previous example of accessing the elements could be written using a **foreach** loop: 

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
            int[ ] a = new int[10];
            for (int k = 0; k < 10; k++) {
                a[k] = k*2;
            }
            foreach (int k in a) {
                Console.WriteLine(k);
            }
        }
    }
}
// OUTPUT
/*
0
2
4
6
8
10
12
14
16
18
*/
```
The **foreach** loop iterates through the array a and assigns the value of the current element to the variable k at each iteration of the loop. So, at the first iteration, k=a[0], at the second, k=a[1], etc.

> The data type of the variable in the **foreach** loop should match the type of the array elements.
>Often the keyword var is used as the type of the variable, as in: **foreach** **(var k in a)**. The compiler determines the appropriate type for **var**.

To create a valid foreach loop that displays all even elements of the array.

```cs
int[ ] nums = { 5, 2, 3, 4, 7};
foreach (var n in nums) {
    if(n%2 == 0)
    Console.WriteLine(n);
}
```

The following code uses a **foreach** loop to calculate the sum of all the elements of an array: 

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
            int[ ] arr = {11, 35, 62, 555, 989};
            int sum = 0; 
            
            foreach (int x in arr) {
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
// OUTPUT
// 1652
```
To review, we declared an array and a variable **sum** that will hold the sum of the elements.

Next, we utilized a **foreach** loop to iterate through each element of the array, adding the corresponding element's value to the **sum** variable.

> The **Array** class provides some useful methods that will be discussed in the coming lessons.