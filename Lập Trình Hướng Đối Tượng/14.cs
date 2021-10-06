// Khuong Viet Tai
/*
 14.Objective (Geometry):
Create a C# program to draw a parallelogram, with the width, height and character requested from the user.

Input:
	10 
	4 
	*


Output:
**********
 **********
  **********
   **********
    **********
     **********
      **********
 */









using System;
class DrawParallelogram
{
    public static void Main(string[] args)
    {
        int width = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());
        char character = Convert.ToChar(Console.ReadLine());
 
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(character);
            }
 
            Console.WriteLine();
 
            for (int c = 0; c <= i; c++)
            {
                Console.Write(" ");
            }
        }
    }
}
