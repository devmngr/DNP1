using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists__Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> temperatures = new List<double>
         {
            1.1,
            1.2,
            1.3,
            12.2,
            22.4,
            32.12,
            33.1,
            43.2,
            88.1,
         };


            foreach (double temp in temperatures)
                if (temp <= 25.0)
                    Console.WriteLine(temp);

            Console.WriteLine("Count larger than 25 is {0}", GreaterCount(temperatures, 25.0));



            #region delegate
            List<double> largetemps = temperatures.FindAll(GreaterThan);
            Console.WriteLine("Count larger than 25 is {0}", largetemps.Count());
            #endregion

            #region anonymous
            List<double> largetemps1 = temperatures.FindAll(delegate (double val)
            {
                return val >= 25.0;
            });
            Console.WriteLine("Count larger than 25 is {0}", largetemps1.Count());

            #endregion
            #region lambda
            List<double> largetemps2 = temperatures.FindAll(d => d >= 25.0);
            Console.WriteLine("Count larger than 25 is {0}", largetemps2.Count());

            #endregion
            Console.ReadKey();






        }

        private static bool GreaterThan(double value)
        {
            return value >= 25;
        }

        static int GreaterCount<T>(List<T> list, T min) where T : IComparable
        {
            int count = 0;
            foreach (T t in list)
            {
                if (t.CompareTo(min) > 0)
                {
                    count++;
                }
            }
            return count;
        }


        static int GreaterCount(List<double> list, double min)
        {
            int count = 0;
            foreach (double temp in list)
                if (temp >= min)
                    count++;

            return count;
        }
    }
}
