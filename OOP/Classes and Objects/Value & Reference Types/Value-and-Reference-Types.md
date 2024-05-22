# Value Types 

C# has two ways of storing data: by **reference** and by **value**.

The built-in data types, such as int and double, are used to declare variables that are **value types**. Their value is stored in memory in a location called the **stack**.

For example, the declaration and assignment statement **int x = 10**; can be thought of as: 

![](/img/125fd3df417e4e0aa7251eb113db9a2a-3011.jpg)

> The value of the variable x is now stored on the stack.

---

# Reference Types

**Reference** types are used for storing objects. For example, when you create an object of a class, it is stored as a reference type.

Reference types are stored in a part of the memory called the **heap**.

When you instantiate an object, the data for that object is stored on the heap, while its heap memory address is stored on the stack.

That is why it is called a reference type - it contains a reference (the memory address) to the actual object on the heap. 

![](/img/718855fe7dc24d1f92ad8e3dc31a8656-7343223c454f4226bd09ba751e6fe698-19.jpg)

As you can see, the **p1** object of type Person on the stack stores the memory address of the heap where the actual object is stored.

> Stack is used for static memory allocation, which includes all your value types, like x.
> Heap is used for dynamic memory allocation, which includes custom objects, that might need additional memory during the runtime of your program.