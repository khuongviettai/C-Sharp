/*
Create a program in C# that asks the user in the first line What is your name? and save the name in the variable x.

The program must respond on the second line with Nice to meet you, x.

Input
	What is your name? x
Output
	Nice to meet you, x
*/


using System;
public class StoreUserInput
{
    public static void Main(string[] args)
    {
        Console.Write("What is your name? ");

	// create x string
        string x = Console.ReadLine();
        Console.WriteLine("Nice to meet you, " + x);
    }
}
