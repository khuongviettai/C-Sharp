/*
Create a C# program that prompts the user for 2 integers and displays a random number on the screen between those values. You can use the .NET Random object.

Input
 
Output
 
*/
using System;

public class RandomNumber
{
    public static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int number = rnd.Next(n1, n2 + 1);

        Console.WriteLine(number);
    }
}
