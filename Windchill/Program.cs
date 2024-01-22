using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windchill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string EingabeTemperatur, EingabeWind;
            double WCT, T, v;

            //getting data and convert to type double 
            Console.WriteLine("Eingabe Temperatur in °C:");
            EingabeTemperatur = Console.ReadLine();
            T = Convert.ToDouble(EingabeTemperatur);
            Console.WriteLine("Eingabe Windgeschwindigkeit in km/h");
            EingabeWind = Console.ReadLine();
            v = Convert.ToDouble(EingabeWind);

            // calculate Windchill temp
            WCT = 13.12 + 0.6215 * T - 11.37 * System.Math.Pow( v,0.16) + 0.3965 * T * System.Math.Pow( v,0.16);

            //print result and wait for input to finish the Programm
            Console.WriteLine("Die gefühlte Temperatur beträgt: {0}", WCT);
            Console.ReadKey();
        }
    }
}
