/*
Create a program in C# that requests a number (x) and displays 10*x.

Must be repeated until the user enters 0.

Input

	5
	4
	6
	0
Output

	50
	40
	60
*/

using System;
public class UsingDoWhile
{
    public static void Main(string[] args)
    {
        int x;

        do
        {
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x * 10);
        }
        while (x != 0);
    }
}
