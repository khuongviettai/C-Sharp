// Khuong Viet Tai
/*
 10.Objective (Flow Controls)
Create a C# program that asks the user for two integers (x, y) and shows the range of those numbers (the two included), in three different ways:
- Using the for statement.
- Using the while statement.
- Using the do while instruction.

Input:
	6
	12


Output:
	6 7 8 9 10 11 12
	6 7 8 9 10 11 12
	6 7 8 9 10 11 12
 */








using System;
public class RepetitiveStructures
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int i;
 
        for (i = x; i <= y; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
 
        i = x;
        while (i <= y)
        {
            Console.Write("{0} ", i);
            i++;
        }
        Console.WriteLine();
 
        i = x;
        do
        {
            Console.Write("{0} ", i);
            i++;
        }
        while (i <= y);
        Console.WriteLine();
    }
}
