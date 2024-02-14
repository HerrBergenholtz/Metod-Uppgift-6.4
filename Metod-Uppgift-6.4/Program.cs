using System;

namespace Uppgift_6_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Välkommen till potensräkning");
            Console.WriteLine("Vilken bas vill du räkna?");
            float bas = float.Parse(Console.ReadLine());
            Console.WriteLine("Vilken exponent vill du exponera med?");
            float exponent = float.Parse(Console.ReadLine());

            Console.WriteLine($"Resultatet blir: {Exponera(bas, exponent)}");
        }

        static double Exponera(float bas, float exponent)
        {
            return Math.Pow(bas, exponent);
        }
    }
}