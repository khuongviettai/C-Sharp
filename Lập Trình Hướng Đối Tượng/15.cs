// Khuong Viet Tai
/*
 15.Objective (Geometry):
Create a C# program that asks the user for text and draws a pyramid on the screen.


Input:
	Copernico

Output:
	r
       ern
      perni
     opernic
    Copernico
 */









using System;
public class DrawTriangle
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
 
        if (text.Length % 2 == 0)
        {
            text += " ";
        }
 
        int position = text.Length / 2;
        int rows = text.Length / 2 + 1;
        int amount = 1;
 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < position; j++)
            { 
                Console.Write(" ");
            }
 
            Console.WriteLine(text.Substring(position, amount));
            position--;
            amount += 2;
        }
    }
}
