/*
Write a program in C# that asks the user for two numbers and one operation (+, -, x, /) then calculate the operation and display the result on the screen.

Show the text Unrecognized character if the operation symbol is different from the previous ones.

You should use the if block.

Input

	4
	x
	4
Output

	4x4= 16
*/
using System;
public class BasicCalculatorIf
{
	public static void Main(string[] args)
	{
		int a = Convert.ToInt32(Console.ReadLine());
		char operation = Convert.ToChar(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		if(operation == '+')
			Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
		else if(operation == '-')
			Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
		else if ((operation == 'x') || (operation == '*'))
			Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
		else if(operation == '/')
			Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
		else
			Console.WriteLine("Unrecognized character");
	}
}
