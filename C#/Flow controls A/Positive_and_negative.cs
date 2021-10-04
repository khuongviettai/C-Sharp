/*
Write a C# program that requests a number (x) and answers if it is positive or negative.

Input

	5
Output

	Positive
*/

using System;
public class PositiveAndNegative
{
	public static void Main(string[] args)
	{
		int x = Convert.ToInt32(Console.ReadLine());
		if(x > 0)
		{
			Console.WriteLine("Positive");
		}
		if(x < 0)
		{
			Console.WriteLine("Negative");
		}
	}
}
