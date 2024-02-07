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
                Prämienstufe = Stk - 150 / 10;
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
