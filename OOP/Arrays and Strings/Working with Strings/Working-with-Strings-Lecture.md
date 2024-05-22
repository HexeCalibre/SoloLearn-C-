# Strings 
It’s common to think of strings as arrays of characters. In reality, strings in C# are objects.

When you declare a **string** variable, you basically instantiate an object of type String.

String objects support a number of useful properties and methods:

**Length** returns the length of the string.

**IndexOf(value)** returns the index of the first occurrence of the value within the string.

**Insert(index, value)** inserts the value into the string starting from the specified index.

**Remove(index)** removes all characters in the string from the specified index.

**Replace(oldValue, newValue)** replaces the specified value in the string.

**Substring(index, length)** returns a substring of the specified length, starting from the specified index. If length is not specified, the operation continues to the end of the string.

**Contains(value)** returns true if the string contains the specified value.


**The examples below demonstrate each of the String members:**

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
            string a = "some text";
            Console.WriteLine(a.Length);
            //Outputs 9

            Console.WriteLine(a.IndexOf('t'));
            //Outputs 5

             a = a.Insert(0, "This is ");
            Console.WriteLine(a);
            //Outputs "This is some text"

            a = a.Replace("This is", "I am");
            Console.WriteLine(a);
            //Outputs "I am some text"

            if(a.Contains("some"))
                Console.WriteLine("found");
            //Outputs "found"

            a = a.Remove(4);
            Console.WriteLine(a);
            //Outputs "I am"

            a = a.Substring(2);
            Console.WriteLine(a);
            //Outputs "am"
        }
    }
}
```
You can also access characters of a string by its index, just like accessing elements of an array:

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
            string a = "some text";
            Console.WriteLine(a.Length);
            //Outputs 9

            Console.WriteLine(a.IndexOf('t'));
            //Outputs 5

             a = a.Insert(0, "This is ");
            Console.WriteLine(a);
            //Outputs "This is some text"

            a = a.Replace("This is", "I am");
            Console.WriteLine(a);
            //Outputs "I am some text"

            if(a.Contains("some"))
                Console.WriteLine("found");
            //Outputs "found"

            a = a.Remove(4);
            Console.WriteLine(a);
            //Outputs "I am"

            a = a.Substring(2);
            Console.WriteLine(a);
            //Outputs "am"
        }
    }
}
```
> Indexes in strings are similar to arrays, they start from 0.

Let's create a program that will take a string, replace all occurrences of the word "dog" with "cat" and output the first sentence only. 

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
            string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";
            text = text.Replace("dog", "cat");
            text = text.Substring(0, text.IndexOf(".")+1);
            
            Console.WriteLine(text);
        }
    }
}
// OUTPUT
// This is some text about a cat.
```
The code above replaces all occurrences of "dog" with "cat". After that it takes a substring of the original string starting from the first index until the first occurrence of a period character.

We add one to the index of the period to include the period in the substring.

> # provides a solid collection of tools and methods to work and manipulate strings. You could, for example, find the number of times a specific word appears in a book with ease, using those methods.

To  assign the last character of the string to the x variable:
```cs
string s = "Hello";
char x;
x = s[s.Length - 1];
```