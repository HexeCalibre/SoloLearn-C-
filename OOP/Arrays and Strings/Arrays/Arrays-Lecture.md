# Arrays

C# provides numerous built-in classes to store and manipulate data.

One example of such a class is the **Array** class.

An array is a data structure that is used to store a collection of data. You can think of it as a collection of variables of the **same type**.

For example, consider a situation where you need to store 100 numbers. Rather than declare 100 different variables, you can just declare an array that stores 100 **elements**.

To declare an array, specify its element types with square brackets

```cs
int[ ] my Array;
```
This statement declares an array of integers.

Since arrays are **objects**, we need to instantiate them with the **new** keyword:

```cs
int[ ] myArray = new int[5];
```
This instantiates an array named myArray that holds 5 integers.

> Note the **square brackets** used to define the number of elements the array should hold.

To instantiate an array of 42 elements of type double:

```cs
double[ ] a = new double[42];
```

After creating the array, you can assign values to individual elements by using the **index number**:

```cs
int[ ] myArray = new int[5];
myArray[0] = 23;
```

This will assign the value 23 to the first element of the array.

> Arrays in C# are zero-indexed meaning the first member has index 0, the second has index 1, and so on.

We can provide initial values to the array when it is declared by using curly brackets:

```cs
string[ ] names = new string[3] {"John", "Mary", "Jessica"};
double[ ] prices = new double[4] {3.6, 9.8, 6.4, 5.9};
```

We can omit the size declaration when the number of elements are provided in the curly braces:

```cs
string[ ] names = new string[ ] {"John", "Mary", "Jessica"};
double[ ] prices = new double[ ] {3.6, 9.8, 6.4, 5.9};
```

We can even omit the new operator. The following statements are identical to the ones above:

```cs
string[ ] names = {"John", "Mary", "Jessica"};
double[ ] prices = {3.6, 9.8, 6.4, 5.9};
```

> Array values should be provided in a comma separated list enclosed in {curly braces}.

To instantiate the array with initial values:

```cs
int[ ] a = { 1, 2, 3 };
```

As mentioned, each element of an array has an index number.

**For example, consider the following array:**

```cs
int[ ] b = {11, 45, 62, 70, 88};
```

The elements of b have the following indexes:

![](/img/array-indexing.jpg)

To access individual array elements, place the element's index number in square brackets following the array name.

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
            int[ ] b = {11, 45, 62, 70, 88};

            Console.WriteLine(b[2]);
            Console.WriteLine(b[3]);
        }
    }
}
// OUTPUT
// 62
// 70
```

> Remember that the first element has index 0.