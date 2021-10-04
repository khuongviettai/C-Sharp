/*
Create a C# program that requests a range of numbers from the user (x, y) and displays them on the screen.

Input

	1
	10
Output

	1 2 3 4 5 6 7 8 9 10
*/
using System;
public class RangeOfNumbers
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = x; i <= y; i++)
        {
             Console.Write("{0} ", i);
        }
    }
}
