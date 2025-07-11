
//Function Overloadding
using System;
class Overloadding
{
	public static void add(int x,int y)
	{
		Console.WriteLine("\nAdd="+(x+y));
	}
	public static void add(int x,int y,int z)
	{
		Console.WriteLine("\nAdd ="+(x+y+z));
	}
	public static void Main(String [] args)
	{
		add(10,20);
		add(10,20,30);
	}
}
