/*
Write a C# program that requests the width (x) and height (y) of a rectangle and calculate the perimeter, area and diagonal.

Perimeter= sum of the four sides.
Area= base x height.
Diagonal= Pythagorean theorem.
Input
	4
	6
Output
	Perimeter: 20
	Area: 24
	Diagonal: 7.21110255092798
*/
using System;
public class DoubleValue
{
    public static void Main(string[] args)
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        double perimeter = a * 2 + b * 2;
        double area = a * b;
	// Math.Sqrt add using Math Library
        double diagonal = Math.Sqrt(a * a + b * b);

        Console.WriteLine("Perimeter: {0}", perimeter);
        Console.WriteLine("Area: {0}", area);
        Console.WriteLine("Diagonal: {0}", diagonal);
    }
}
