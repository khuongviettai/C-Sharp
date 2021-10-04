/*
Create a program C# to ask the user for a distance in meters and the time taken (hours, minutes, seconds).

Display the speed, in meters per second, kilometers per hour and miles per hour.

1 mile = 1609 meters.

Input
	1200
	0
	13
	45
Output
	Speed in meters/sec is 1.454545
	Speed in km/h is 5.236363
	Speed in miles/h is 3.254421
*/
using System;
public class FloatSpeedUnits
{
    public static void Main(string[] args)
    {
        float distance = Convert.ToSingle(Console.ReadLine());
        float hour = Convert.ToSingle(Console.ReadLine());
        float min = Convert.ToSingle(Console.ReadLine());
        float sec = Convert.ToSingle(Console.ReadLine());

        float timeBySeconds = (hour*3600) + (min*60) + sec;
        float mps = distance/timeBySeconds;
        float kph = (distance/1000.0f) / (timeBySeconds/3600.0f);
        float mph = kph/1.609f;

        Console.WriteLine("Speed in meters/sec is {0}", mps);
        Console.WriteLine("Speed in km/h is {0}", kph);
        Console.WriteLine("Speed in miles/h is {0}", mph);
    }
}
