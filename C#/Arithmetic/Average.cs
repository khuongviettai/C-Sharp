/*
Write a C# program that calculates the arithmetic measurement of 4 factors entered by the user, one for each line.

Input
	4
	6
	8
	2
Output
	5
*/

using System;
public class Average
{
    public static void Main(string[] args)
    {
        int x1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int x3 = Convert.ToInt32(Console.ReadLine());
        int x4 = Convert.ToInt32(Console.ReadLine());

        int result = (x1+x2+x3+x4)/4;
        Console.WriteLine(result);
    }
}
