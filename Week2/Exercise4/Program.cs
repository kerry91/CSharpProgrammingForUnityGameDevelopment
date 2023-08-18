using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            int altitudeChange = secondAltitude - firstAltitude;
            Console.WriteLine(altitudeChange);
        }
    }
}