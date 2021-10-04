/*
Write a program in C# that requests an integer x from the user and print the result of adding it to the square.

Input
	2
Output
	2x2= 4
*/

using System;
public class SumsSquared
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}+{0}= {1}",x,x*x);
    }
}
