using System;
public class DisplayGraphicFunction
{
    public static void Main(string[] args)
    {
        int x1= Convert.ToInt32(Console.ReadLine());
        int x2= Convert.ToInt32(Console.ReadLine());
        int y;
		
        for (int x = x1; x <= x2; x++)
        {
            y = (x-4)*(x-4);
            for (int j = 0; j < y; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
