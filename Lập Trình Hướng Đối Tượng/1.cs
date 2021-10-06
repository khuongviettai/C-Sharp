// Khuong Viet Tai




/*
 1. Objective:(Arithmetic):
Create a program C# to display certain values of the function y= x2 - 2x + 1. Ask the user for the range of integers x to show the function.
Input: -10 10,
output: 121 100 81 64 49 36 25 16 9 4 1 0 1 4 9 16 25 36 49 64 81
 */







using System;
public class Arithmetic
{
    public static void Main(string[] args)
    {
	// Enter data x1
        int x1= Convert.ToInt32(Console.ReadLine());
	//Enter data x2
        int x2= Convert.ToInt32(Console.ReadLine());
        int y;
	//loop to check for integers in the range x1 to x2		
        for (int x=x1;x<=x2;x++)
        {
            y= x*x-2*x+1;
	    //show results
            Console.Write("{0} ", y);
        }
    }
}
