/*
Write a program in C# that requests a number x and then displays a rectangle 3 columns wide and 5 rows high using that digit.

Input

	3
Output
	333
	333
	333
	333
	333
*/

using System;
public class DrawRectangle
{
	public static void Main()
	{
		int x = Convert.ToInt32(Console.ReadLine());
		for(int i = 0; i < 5; i++)
		{
			Console.WriteLine("{0}{0}{0}", x);
		}
	}
}
