//Single inheritance program

using System;
class Parent
{
	public
	String Father_Name="Abc";
	public
	String SurName="Xyz";
}
class Child :Parent
{
public static void Main(String [] args)
{
Child C=new Child();
Console.WriteLine("\nFather Name :-"+(C.Father_Name));
Console.WriteLine("SurName :-"+(C.SurName));
}
}
