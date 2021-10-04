/*
Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.

In addition you should also calculate the rest of the division on the last line.

Input
	12
	3
Output
	12 + 3 = 15
	12 - 3 = 9
	12 x 3 = 36
	12 / 3 = 4
	12 mod 3 = 0
*/

using System;
public class Basiccalculator
{
	public static void Main(string[], args)
	{
		int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
        	Console.WriteLine("{0} - {1} = {2}", x, y, x-y);
        	Console.WriteLine("{0} x {1} = {2}", x, y, x*y);
        	Console.WriteLine("{0} / {1} = {2}", x, y, x/y);
        	Console.WriteLine("{0} mod {1} = {2}", x, y, x%y);
	}
}
