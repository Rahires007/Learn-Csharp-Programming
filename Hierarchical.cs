using System;

class GrandFather
{
    public string GrandFather_Name = "Abc";
    public string SurName = "Xyz";
}

class Father : GrandFather
{
    public void set()
    {
        Father F = new Father();
        Console.WriteLine("\nFather Name :- " + F.GrandFather_Name);
        Console.WriteLine("Sur Name :- " + F.SurName);
    }
}

class Kaka : GrandFather
{
    public void get()
    {
        Kaka K = new Kaka();
        Console.WriteLine("\nFather Name :- " + K.GrandFather_Name);
        Console.WriteLine("Sur Name :- " + K.SurName);
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Father f = new Father();
        f.set();

        Kaka k = new Kaka();
        k.get();
    }
}
