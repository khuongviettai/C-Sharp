/*
Create a program C# to display certain values of the function y= x2 - 2x + 1. Ask the user for the range of integers x to show the function.

Input
	-10
	10
Output
	121 100 81 64 49 36 25 16 9 4 1 0 1 4 9 16 25 36 49 64 81
*/

using System;
public class CalculateValuesFunction
{
    public static void Main(string[] args)
    {
        int x1= Convert.ToInt32(Console.ReadLine());
        int x2= Convert.ToInt32(Console.ReadLine());
        int y;

        for (int x=x1;x<=x2;x++)
        {
            y= x*x-2*x+1;
            Console.Write("{0} ", y);
        }
    }
}
