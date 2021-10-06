// Khuong Viet Tai
/*
 7. Objective(FlowControls)
Create a C# program that shows numbers 1 through 500 that are multiples of 3 and also multiples of 5.

Input:


Output:
	15 30 45 60 75 90 105 120 135 150 165 180 195 210 225 240 255 270 285 300 315 330 345 360 375 390 405 420 435 450 465 480 495
  */






using System;
public class MultiplesNumbers
{
    public static void Main()
    {
        for (int i = 1; i <= 500; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                Console.Write("{0} ", i);
        }
    }
}
