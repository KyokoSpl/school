using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie die Anzahl der Geschwindigkeiten ein:");
        int numSpeeds = int.Parse(Console.ReadLine());

        double acceleration = 8; // Bremsbeschleunigung in m/s²

        for (int i = 1; i <= numSpeeds; i++)
        {
            Console.WriteLine($"Eingabe {i}: Geschwindigkeit {i}:");
            double velocityKmh = Convert.ToDouble(Console.ReadLine());
            double velocityMs = velocityKmh * 1000 / 3600; // Umrechnung von km/h in m/s
            double brakingDistance = (velocityMs * velocityMs) / (2 * acceleration);
            Console.WriteLine($"Bremsweg bei Geschwindigkeit {velocityKmh} km/h: {brakingDistance:F2} m \n");

        }
        Console.WriteLine("press any key to exit the programm");
        Console.ReadKey();
    }
}
