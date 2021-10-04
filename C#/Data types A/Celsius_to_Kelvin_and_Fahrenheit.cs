/*
The Celsius scale is centigrade, 100 divisions separate the freezing point from the boiling point of water. On the Fahrenheit scale of Anglo-Saxons, these two points are 180 degrees apart. The Kelvin scale is an absolute scale used in science.

Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit. Request the user the number of degrees celsius to convert them using the following conversion tables:

kelvin = celsius + 273
fahrenheit = celsius x 18 / 10 + 32
Input
	33
Output
	kelvin= 306
	fahrenheit= 91

*/

using System;
public class ConvertCelciusToKelvinAndFahrenheit
{
    public static void Main(string[] args)
    {
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("kelvin= {0}", celsius + 273);
        Console.WriteLine("fahrenheit= {0}", celsius * 18 / 10 + 32);
    }
}

