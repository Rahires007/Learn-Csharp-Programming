
//Package program
using System;

namespace MyPackage
{
	class Sample
	{
		public void Show()
		{
			Console.WriteLine("Hello from MyPackage");
		}
	}
}

class Program
{
	public static void Main(String[] args)
	{
		MyPackage.Sample s = new MyPackage.Sample();
		s.Show();
	}
}
