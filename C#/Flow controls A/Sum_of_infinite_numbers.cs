/*
Write a program in C# that asks for numbers and shows their sum. Request numbers until the user enters 0 and when the program ends show Finished.

Input

	7
	4
	22
	-8
	6
	0
Output

	7
	11
	33
	25
	31
	Finished
*/

using System;
public class SumInfiniteNumbers
{
    public static void Main(string[] args)
    {
        int x;
        int sum = 0;

        do
        {
            x = Convert.ToInt32(Console.ReadLine());
            sum = x + sum;

            if (x != 0)
                Console.WriteLine(sum);
        }
        while (x != 0);

        Console.WriteLine("Finished");
    }
}
