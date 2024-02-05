using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS_seconds_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define all variables with correct Datatype
            String DezimalMinuteText;
            double DezimalMinute;
            double Integer;
            double Second;
            double Leftover;

            //prompt the user to enter a Dezimalminute and convert it to double cause the console only parses Strings ans input
            Console.WriteLine("Enter Dezimalminute");
            DezimalMinuteText = Console.ReadLine();
            DezimalMinute = Convert.ToDouble(DezimalMinuteText);

            // doing the Math
            Integer = Math.Truncate(DezimalMinute); //Truncate entfernt das Komma und wandelt die Zahl in eine Ganzzahl um
            Leftover = DezimalMinute - Integer;
            Second = Leftover * 60.0;
            Console.WriteLine("Second = {0} Leftover = {1}", Second, Leftover); // printing the variables
            Console.WriteLine("Press Any Key to exit"); //prompts the user to press a key to finish the programm
            Console.ReadKey();
        }
    }
}
