/*
Write a program to ask the user for three letters and display them in reverse order.

Input
	a
	b
	c
Output
	c b a
*/

using System;
public class ReverseChars
{
    public static void Main(string[] args)
    {
        char a = Convert.ToChar(Console.ReadLine());
        char b = Convert.ToChar(Console.ReadLine());
        char c = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("{0} {1} {2}", c, b, a);
    }
}

