/*
Write a program in C# that requests two integers from the user (x, y) and print the result of the division and the rest of the division on a new line.

Input
	24
	5
Output
	4
	4
 */

using System;
public class DivisionTwoNumbers
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(x/y);
        Console.WriteLine(x%y);
    }
}
