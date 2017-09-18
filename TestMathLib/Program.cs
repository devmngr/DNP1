using DNP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 10;
    
            double c = 7.29;
            double d = 1.32;

            MathLib m = new MathLib();

            Console.WriteLine(a + " + " + b + " = {0:g}", m.int_addition(a,b));
            Console.WriteLine(a + " - " + b + " = {0:g}", m.int_subtraction(a, b));
            Console.WriteLine(a + " * " + b + " = {0:g}", m.int_multiplication(a, b));
            Console.WriteLine(a + " / " + b + " = {0:g}", m.int_division(a, b));

            Console.WriteLine();

            Console.WriteLine(c + " + " + d + " = {0:n}", m.double_addition(c,d));
            Console.WriteLine(c + " - " + d + " = {0:n}", m.double_subtraction(c, d));
            Console.WriteLine(c + " * " + d + " = {0:n}", m.double_multiplication(c, d));
            Console.WriteLine(c + " / " + d + " = {0:n}", m.double_division(c, d));
        }
    }
}
