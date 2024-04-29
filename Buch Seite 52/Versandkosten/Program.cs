using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versandkosten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] shippingcost_arr = new double[10] { 30, 40, 50, 60, 70, 80, 90, 69, 420, 666 };
            double shippingcost;
            string itemgroup_in;
            

            Console.WriteLine("geben sie die identnummer ihrer Warengruppe ein [1-10]");
            itemgroup_in = Console.ReadLine();
            int itemgroup = Convert.ToInt32(itemgroup_in);
            shippingcost = shippingcost_arr[itemgroup-1];
            Console.WriteLine("Die Versandcosten für Warengruppe:{0} betragen {1}EUR", itemgroup, shippingcost);
            Console.ReadKey();
        }
    }
}
