/*
Write a program in C# that asks the user for a number x and shows the result of his multiplication table from 1 to 10.

Input
	5
Output
	5x1= 5
	5x2= 10
	5x3= 15
	5x4= 20
	5x5= 25
	5x6= 30
	5x7= 35
	5x8= 40
	5x9= 45
	5x10= 50
*/
using System;
public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<=10;i++)
        {
            Console.WriteLine("{0}x{1}= {2}", x, i, x*i);
        }
    }
}
