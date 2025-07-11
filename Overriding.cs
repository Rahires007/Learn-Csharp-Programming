//Method Overriding Program

using System;

class Parent
{
    public virtual void CompleteGraduation()
    {
        Console.WriteLine("\nIn Btech");
    }
}

class Child : Parent
{
    public override void CompleteGraduation()
    {
        Console.WriteLine("\nIn Bcs");
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Child C = new Child();
        C.CompleteGraduation();
    }
}
