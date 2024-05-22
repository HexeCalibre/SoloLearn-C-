# Indexers

An **indexer** allows objects to be indexed like an array. 

As discussed earlier, a string variable is actually an object of the **String** class. Further, the String class is actually an array of Char objects. In this way, the string class implements an indexer so we can access any character (Char object) by its index: 

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
            string str = "Hello World";
            char x = str[4];
            Console.WriteLine(x);
        }
    }
}
// OUTPUT
// o
```

> Arrays use integer indexes, but indexers can use any type of index, such as strings, characters, etc.

Declaration of an indexer is to some extent similar to a property. The difference is that indexer accessors require an **index**. 

Like a property, you use **get** and **set** accessors for defining an indexer. However, where properties return or set a specific data member, indexers return or set a particular value from the object instance. 

Indexers are defined with the **this** keyword.

**For example:**
```cs
class Clients {
  private string[] names = new string[10];

  public string this[int index] {
    get {
      return names[index];
    }
    set {
      names[index] = value;
    }
  }
}
```

As you can see, the indexer definition includes the **this** keyword and an index, which is used to get and set the appropriate value.

Now, when we declare an object of class Clients, we use an index to refer to specific objects like the elements of an array:

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
        class Clients {
            private string[] names = new string[10];
            public string this[int index] {
                get {
                    return names[index];
                }
                set {
                    names[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";
            
            Console.WriteLine(c[1]);
        }
    }
}
// OUTPUT
// Bob
```

> You typically use an indexer if the class represents a list, collection, or array of objects.

