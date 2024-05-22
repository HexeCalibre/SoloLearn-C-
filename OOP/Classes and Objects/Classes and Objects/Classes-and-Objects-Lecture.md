# Classes 

As we have seen in the previous modules, built-in data types are used to store a single value in a declared variable. For example, **int x** stores an integer value in a variable named **x**.

In object-oriented programming, a **class** is a data type that defines a set of variables and methods for a declared **object**.

 For example, if you were to create a program that manages bank accounts, a **BankAccount** class could be used to declare an object that would have all the properties and methods needed for managing an individual bank account, such as a **balance** variable and **Deposit** and **Withdrawal** methods. 

A class is like a **blueprint**. It defines the data and behavior for a type. A class definition starts with the keyword **class** followed by the class name. The class body contains the data and actions enclosed by curly braces. 

```cs
class BankAccount
{
  //variables, methods, etc.
}
```

The class defines a data type for objects, but it is not an object itself. An **object** is a concrete entity based on a class, and is sometimes referred to **as an instance of a class**.

---

# Objects 

Just as a built-in data type is used to declare multiple variables, a class can be used to declare multiple **objects**. As an analogy, in preparation for a new building, the architect designs a blueprint, which is used as a basis for actually building the structure. That same blueprint can be used to create multiple buildings.

Programming works in the same fashion. We define (design) a class that is the blueprint for creating objects.

In programming, the term **type** is used to refer to a class **name**: We're creating an object of a particular **type**.

Once we've written the class, we can create objects based on that class. Creating an object is called **instantiation**.

> An object is called an instance of a class.

Each object has its own characteristics. Just as a person is distinguished by name, age, and gender, an object has its own set of values that differentiate it from another object of the same type.

The characteristics of an object are called **properties**. 

Values of these properties describe the current state of an object. For example, a Person (an object of the class Person) can be 30 years old, male, and named Antonio.

 

Objects aren't always representative of just physical characteristics. 

For example, a programming object can represent a date, a time, and a bank account. A bank account is not tangible; you can't see it or touch it, but it's still a well-defined object because it has its own properties.