// Khuong Viet Tai
/*
 17.Objective (Data type)

 Create a program in C# that asks the user for an integer (x) and displays it in hexadecimal and binary.
Must be repeated until the user enters a 0.


Input:
	25
	0
Output:
	19
	11001
 */






using System;
public class ConvertIntegerToBinaryAndHexadecimal
{
    public static void Main(string[] args)
    {
        int x;
 
        do
        {
            x = Convert.ToInt32(Console.ReadLine());
 
            if (x != 0)
            {
                Console.WriteLine(Convert.ToString(n, 16));
                Console.WriteLine(Convert.ToString(n, 2));
            }
        }
        while (x != 0);
    }
}
