# PRACTICE EXERCISE : Working with Strings

You are creating an authentication system.

The password shouldn't contain any of these symbols:

```cs
char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' }; 
```
The given program takes the password as input.

**Task**
Write a program to output **"Invalid"**, if  it contains any disallowed symbols.

If the password requirement is satisfied, program shouldn't output anything.

**Sample Input**
```
yl1893!dm$
```

**Sample Output**
```
Invalid
```

**Hint**
The message should be output only once regardless of how many disallowed symbols the password contains.

> Use the **for/foreach** loop to iterate through the array of disallowed symbols and check the condition, then use the **break** keyword to stop the iteration if the condition is evaluated as true.

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            //your code goes here
            
        }
    }
}
```

