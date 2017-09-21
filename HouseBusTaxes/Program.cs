using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBusTaxes
{
    class Program
    {
        static void Main(string[] args)
        {

            ITaxable busTax = new Bus(123,3500, 1000, 13);
            ITaxable housTax = new House("Arhus", true, 13, 8210);

            Console.WriteLine("{0:g}", busTax.TaxValue());
            Console.WriteLine("{0:g}", housTax.TaxValue());

        }
    }
}
