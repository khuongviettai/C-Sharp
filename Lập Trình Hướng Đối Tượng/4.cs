// Khuong Viet Tai
//


/*
 * 4. Objective(Geometry):
Write a program in C# that asks the user for a string and displays a right-aligned triangle.

Input:
	Jonny

Output:
	y
	ny
	nny
	onny
	Jonny
 */





using System;
public class DrawRightAlignedTriangle
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
       
        int j = 1;
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(text.Substring(i, j));
            j++;
        }
    }
}
