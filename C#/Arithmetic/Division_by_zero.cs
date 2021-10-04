/*
 Create a C# program that asks the user for two numbers (x, y) and shows the result of their division.

You will have to control division by 0 with the use of the DivideByZeroException exception in a try-catch block. If the user tries to divide by 0, it Cannot be divided by 0.

Input
	6
	0
Output
	Cannot divide by 0
 */

using System;
public class DivisionByZero
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.WriteLine("{0}/{1}= {2}", x, y, x / y);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by 0");
        }
    }
}
