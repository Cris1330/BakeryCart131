using System;
using System.Collections.Generic;
using System.Linq;
using BakeryCart131;

namespace BakeryCart131
{
    class Program
    {
        static void Main()
        {
            MyClass<string> newClass = new MyClass<string>();
            newClass.MyProperty = "A value";
            newClass.MyProperty2 = "AnotherValue";

            newClass.PrintSomething();
            newClass.PrintSomethingElse("Print this");
        }
    }
}

public class MyClass<T>
{
    public string MyProperty { get; set; }
    public T MyProperty2 { get; set; }

    public void PrintSomething()
    {
        Console.WriteLine("This is an action");
    }
    
}