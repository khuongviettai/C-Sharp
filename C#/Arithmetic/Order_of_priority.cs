/*
Create a C# program that requests an integer x from the user and print the result of the following operations:

-6 + x * 5
(13-2) * x
(x + -2) * (20 / 10)
(12 + x) / (5 - 4)
Input
	2
Output
	4
	22
	0
	14
*/

using System;
public class MultipleOperations
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(-6+x*5);
        Console.WriteLine((13-2)*x);
        Console.WriteLine((x+-2)*(20/10));
        Console.WriteLine((12+x)/(5-4));
    }
}

