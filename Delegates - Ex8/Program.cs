using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Ex8
{
    class Program
    {
        delegate void IntAction(int n);
        static void Main(string[] args)
        {
            //Question A
            IntAction act = PrintInt;
            act(42);

            //Qustion B
            int[] list = {1,2,3,4,5,6,7,8,9,10 };
            Perform(act, list);

            //Another way
           // Perform(act, 11, 12, 13, 14, 15, 17, 18, 20, 22, 12);

        }

        static void  PrintInt(int n)
        {
            Console.WriteLine("Printing an integer = {0}", n);
        }
        static void Perform(IntAction act, int[] arr)
        {
            foreach(int item in arr)
            {
                act(item);
            }
        }
    }
}
