// Class and Object program using Encapsulation
using System;

class Encapsulation
{
  
    public void Square(int x)
    {
        Console.WriteLine("\nSquare = " + (x * x));
    }

   
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int Num = Convert.ToInt32(Console.ReadLine());
        
        Encapsulation Encap = new Encapsulation();
        Encap.Square(Num);
    }
}

