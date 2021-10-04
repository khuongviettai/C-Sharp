/*
Write a C# program that asks the user What is your favorite animal?. Then stop program execution using the Console.Read statement. When the user presses Enter the program will respond Mine too! on the second line.

Input
 
Output
	What is your favorite color?
	Mine too!
*/

using System;
public class ReadingUserInput
{
    public static void Main(string[] args)
    {
	// Console.Write display What is your favorite color
        Console.Write("What is your favorite color? ");

	// Console.ReadLine is Enter from keybord
        Console.ReadLine();

	//Console.WriteLine display mine too!
        Console.WriteLine("Mine too!");
    }
}
