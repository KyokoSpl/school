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
            const int  normalpricebrutto = 68;
            float normalpricenetto;
            int kilometer;
            int kmextra;
            string kminput;
            const float additional = 0.65f;
            float finalpricebrutto;
            float finalpricenetto;
            const float mwst = 0.19f;

            // Get user input and covert to correct data type
            Console.WriteLine("price calc");
            Console.Write("please enter kilometer:");
            kminput = Console.ReadLine();
            kilometer = Convert.ToInt32(kminput);

            if(kilometer > 200)
            {
                // calculate price if they drove over 200km
                kmextra = kilometer - 200;
                finalpricebrutto = normalpricebrutto + additional * kmextra;
                finalpricenetto = finalpricebrutto + finalpricebrutto * mwst;
                Console.WriteLine("your final price is {0} tax included. Taxes: {1}", finalpricenetto,mwst);
            }
            else
            {
                // calculate price if they're in the normal price range
                normalpricenetto = normalpricebrutto * mwst;
                normalpricenetto = normalpricebrutto + mwst;
                
                Console.WriteLine("your final price is {0} tax included. Taxes: {1}", normalpricenetto, mwst);
            }
            // request user input to close programm
            Console.WriteLine("press any key to leave");
            Console.ReadKey();
        }
    }
}
