//Multilevel inheritacne program
using System;
class GrandFather
{
	public
	String GrandFather_Name="Abc";
	public
	String Sur_Name="Xyz";
}
class Father : GrandFather
{
public 
String Father_Name="Pqr";
}
class Child : Father
{
public static void Main(String [] args)
{
Child C=new Child();
Console.WriteLine("Father_Name :-"+(C.Father_Name));
Console.WriteLine("\nGrandFather_Name :-"+(C.GrandFather_Name));
Console.WriteLine("\nSur Name :-"+(C.Sur_Name));
}
}
