//Khuong Viet Tai
/*
 9. Objective(FlowControls)
Write a program in C# that asks the user for two numbers and shows the division and the rest of the division. Notify if 0 is entered as the second number and end if 0 is entered as the first number.


Input:
	6
	0
	20
	10
	5
	5
	0

Output:
	You cannot divide by 0
	The division is 2
	The rest is 0
	The division is 1
	The rest is 0
	Goodbye!
 */







using System;
public class InfiniteDivisions
{
    public static void Main(string[] args)
    {
        int num1, num2;
        do
        {
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 != 0)
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by 0");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Division is {0}", num1 / num2);
                    Console.WriteLine("Remainder is {0}", num1 % num2);
                    Console.WriteLine();
                }
            }
        }
        while (num1 != 0);
        Console.WriteLine("Bye!");
    }
}
