// Khuong Viet Tai
/*
 11.Objective: (Char Alphabet):
Write a C# program that shows the letters of the alphabet in capital letters using only a for loop and char variables.

Input:

Output:
	A B C D E F G H I K L M N O P Q R S T V X Y Z
 */







using System;
public class Alphabets
{
    public static void Main(string[] args)
    {
        char a;
	for(a = 'A'; a <= 'Z'; a++)
		Console.WriteLine(a);
    }
}
