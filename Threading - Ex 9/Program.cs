using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading___Ex_9
{
    class Program
    {
        static void Main(string[] args)
        {

            string txt1 = "D:/GitHub/DNP1/Threading - Ex 9/TextFile1.txt";
            string txt2 = "D:/GitHub/DNP1/Threading - Ex 9/TextFile2.txt";


            Reader read1 = new Reader(txt1);
            Reader read2 = new Reader(txt2);

            Thread one = new Thread(read1.Read);
            Thread two = new Thread(read2.Read);

            one.Start();
            two.Start();

            one.Join();
            two.Join();

            if (read1.data.Length == read2.data.Length)
            {
                if (read1.data.Length == read2.data.Length)
                    Console.WriteLine("The files are EQUAL \n{0} \n{1}", txt1, txt2);
                else
                    Console.WriteLine("The files are NOT EQUAL \n{0} \n{1}", txt1, txt2);

            }
            else
                Console.WriteLine("Thefiles are NOT EQUAL");





        }
    }
}
