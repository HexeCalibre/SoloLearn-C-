# Encapsulation 
Part of the meaning of the word **encapsulation** is the idea of "surrounding" an entity, not just to keep what's inside together, but also to protect it.

In programming, encapsulation means more than simply combining members together within a class; it also means restricting access to the inner workings of that class.

Encapsulation is implemented by using **access modifiers**. An access modifier defines the scope and visibility of a class member.

> Encapsulation is also called **information hiding**.

C# supports the following access modifiers: **public, private, protected, internal, protected internal.**

As seen in the previous examples, the **public** access modifier makes the member accessible from the outside of the class. 

The **private** access modifier makes members accessible only from within the class and hides them from the outside.

> **protected** will be discussed later in the course.

To show encapsulation in action, let’s consider the following example: 

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class BankAccount {
        private double balance=0;
        public void Deposit(double n) {
            balance += n;
        }
        public void Withdraw(double n) {
            balance -= n;
        }
        public double GetBalance() {
            return balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            b.Deposit(199);
            b.Withdraw(42);
            Console.WriteLine(b.GetBalance());
        }
    }
}

// OUTPUT
// 157
```

We used encapsulation to hide the **balance** member from the outside code. Then we provided restricted access to it using public methods. The class data can be read through the **GetBalance** method and modified only through the **Deposit** and **Withdraw** methods.

You cannot directly change the **balance** variable. You can only view its value using the public method. This helps maintain data integrity.

We could add different verification and checking mechanisms to the methods to provide additional security and prevent errors.

> In summary, the benefits of encapsulation are:
>
> - Control the way data is accessed or modified.
>
> - Code is more flexible and easy to change with new requirements.
>
> - Change one part of code without affecting other parts of code.

