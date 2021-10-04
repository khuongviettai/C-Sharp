/*
Write a program in C# that asks the user for two numbers and one operation (+, -, x, /) then calculate the operation and display the result on the screen.

Show the text Unrecognized character if the operation symbol is different from the previous ones.

You should use the switch block.

Input

	6
	-
	4
Output

	6-4= 2
*/

using System;
public class BasicCalculatorSwitch
{
	public static void Main(string[] args)
	{
		int a = Convert.ToInt32(Console.ReadLine());
		char operation = Convert.ToChar(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());

		switch(operation)
		{
			case '+':
				Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
				break;
			case '_':
				Console.WriteLine("{0} - {1} = {2}",a, b, a - b);
				break;
			case 'x':
			case '*':
				Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
				break;
			case '/':
				Console.WriteLine("{0} / {1} = {2}",a, b, a / b);
				break;
			default:
				Console.WriteLine("Unrecognized character");
				break;
		}
	}
}
