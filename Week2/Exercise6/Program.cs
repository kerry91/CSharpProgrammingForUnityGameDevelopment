using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Exercise6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your angle:");
        float angle = float.Parse(Console.ReadLine());
        angle *= (float)Math.PI / 180;
        Console.WriteLine(Math.Cos(angle));
        Console.WriteLine(Math.Sin(angle));
    }
}
