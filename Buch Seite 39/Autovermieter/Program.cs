using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermieter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining variables
            int  normalpricebrutto = 68;
            double normalpricenetto;
            double kilometer;
            double kmextra;
            string kminput;
            double additional = 0.65;
            double finalpricebrutto;
            double finalpricenetto;
            double mwst;

            // Get user input and covert to correct data type
            Console.WriteLine("price calc");
            Console.Write("please enter kilometer:");
            kminput = Console.ReadLine();
            kilometer = Convert.ToDouble(kminput);

            if(kilometer > 200)
            {
                // calculate price if they drove over 200km
                kmextra = kilometer - 200;
                finalpricebrutto = normalpricebrutto + additional * kmextra;
                mwst = finalpricebrutto * 0.19;
                finalpricenetto = finalpricebrutto + mwst;
                Console.WriteLine("your final price is {0} tax included. Taxes: {1}", finalpricenetto,mwst);
            }
            else
            {
                // calculate price if they're in the normal price range
                mwst = normalpricebrutto * 0.19;
                normalpricenetto = normalpricebrutto + mwst;
                
                Console.WriteLine("your final price is {0} tax included. Taxes: {1}", normalpricenetto, mwst);
            }
            // request user input to close programm
            Console.WriteLine("press any key to leave");
            Console.ReadKey();
        }
    }
}
