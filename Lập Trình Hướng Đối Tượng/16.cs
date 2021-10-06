// Khuong Viet Tai
/*
16. Objective(Mathematical)
Create a C# program that asks the user for an integer (x) and displays the product of its prime factors.


Input: 
	60

Output:
	2x2x3x5x1
*/







using System;
public class ProductOfFactorsPrimes
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int divisor = 2;
 
        while (x > 1)
        {
            while (x % divisor == 0)
            {
                Console.Write(divisor + "x");
                x = x / divisor;
            }
            divisor++;
        }
        Console.Write(1);
    }
}
