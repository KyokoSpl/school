using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prämienlohn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Stk_text;
            double Stk;
            double Prämie;
            double Prämienstufe;
            double Gesamtlohn;

            Console.WriteLine("Geben sie die Stückzahl ein");
            Stk_text = Console.ReadLine();
            Stk = Convert.ToDouble(Stk_text);

            if( Stk > 150)
            {
                Prämienstufe = (Stk - 150) / 10;
                Prämie = Prämienstufe * 0.002;
                Gesamtlohn = 5 * 8 + Prämie;
                Console.WriteLine("Der gesamtlohn Beträgt {0}€, Die Prämie beträgt {1}€", Gesamtlohn, Prämie);
            }
            else
            {
                Gesamtlohn = 5 * 8;
                Console.WriteLine("Der Lohn beträgt{0}", Gesamtlohn);
            }
            Console.WriteLine("Press any Key to exit the Programm");
            Console.ReadKey();
        }
    }
}




using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Body Mass Index (BMI) Calculator");
        Console.WriteLine("---------------------------------");

        Console.Write("Enter your weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        double height = double.Parse(Console.ReadLine());

        double bmi = CalculateBMI(weight, height);
        Console.WriteLine($"Your BMI is: {bmi}");

        Console.WriteLine("BMI Categories:");
        Console.WriteLine("Underweight: BMI < 18.5");
        Console.WriteLine("Normal weight: 18.5 <= BMI < 25");
        Console.WriteLine("Overweight: 25 <= BMI < 30");
        Console.WriteLine("Obesity: BMI >= 30");

        Console.ReadLine(); // So that the console doesn't close immediately
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
}

