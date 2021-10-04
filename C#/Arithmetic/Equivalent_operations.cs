/*
Write a C# program to ask the user for three numbers (a, b, c) and display the result of (a+b)*c and the result of a * c + b*c.

Input
	2
	4
	2
Output
	12
	12
*/

using System;
public class EquivalentOperations
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
    	int b = Convert.ToInt32(Console.ReadLine());
    	int c = Convert.ToInt32(Console.ReadLine());

    	Console.WriteLine((a+b)*c);
    	Console.WriteLine(a*c+b*c);
    }
}
