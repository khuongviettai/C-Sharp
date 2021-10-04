/*
Write a program in C # that asks for three numbers (x, y, z) and display the greatest one.

Input

	6
	12
	19
Output

	19
*/

using System;
public class GreatestThreeNumbers
{
	public static void Main(string[] args)
	{
		int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		int z = Convert.ToInt32(Console.ReadLine());

		if(x > y && x > z)
		{
			Console.WriteLine(x);
		}
		else if (y > x && y > z)
		{
			Console.WriteLine(y);
		}
		else if (z > x && z > y)
		{
			Console.WriteLine(z);
		}
		else{
			Console.WriteLine(x);
		}
	}
}
