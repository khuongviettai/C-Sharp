/*
Create a program in C# for calculate the surface and volume of a sphere, given its radius.

surface= 4 * pi * radius squared
volume= 4 / 3 * pi * radius cubed
Input
	60
Output
	Surface: 45238,93
	Volume: 678584,1
*/

using System;
public class CalculateSurfaceAndVolumeOfSphere
{
    public static void Main(string[] args)
    {
        float radius = Convert.ToSingle(Console.ReadLine());
        float pi = 3.1415926535f;

        float surface = 4 * pi * (radius * radius);
        float volume = 4 / 3 * pi * (radius * radius * radius);

        Console.WriteLine("Surface: " + surface);
        Console.WriteLine("Volume: " + volume);
    }
}
