using ForLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            CLBirdie birdie = new CLBirdie();
            string sound = birdie.makeSomeNoise();
            Console.WriteLine(sound);
        }

       /* prints every second number in the range from 100 to 202 both inclusive */
        static void second_number_fwd()
        {
            for (int i = 100; i <= 202; i += 2)
            {
                Console.WriteLine(i);
            }
        }


        /* prints every second number in the range from 100 to 202 in reverse order */
        static void second_number_reverse()
        {
            for (int i = 202; i >= 100; i -= 2)
            {
                Console.WriteLine(i);
            }
        }

        /* prints every second number in the range from 100 to 202 */
        static void second_number_while_loop()
        {
            int i = 100;
            while (i <= 202)
            {
                Console.WriteLine(i);
                i += 2;
            }

        }

        /* prints every second number in the range from 100 to 202 using a switch to hande special cases */
        static void second_number_while_loop_switch()
        {
            int i = 100;
            while (i <= 202)
            {
                switch (i)
                {
                    case 110:
                        Console.WriteLine("This is a funny number");
                        break;

                    case 130:
                        Console.WriteLine("This is a funny number");
                        break;

                    case 140:
                        Console.WriteLine("This is a funny number");
                        break;

                    case 122:
                        Console.WriteLine("This is my lucky number");
                        break;

                    case 198:
                        break;

                    default:
                        Console.WriteLine(i);
                        break;
                }

                i += 2;

            }

        }

        /* print every number in the range from 1 to 255 (both inclusive) in hexadecimal with special  */
        static void loop_1_to_155_hex()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i <= 16)
                {
                    if (i == 16)
                    {
                        Console.Write("{0:X} ", i);
                        Console.WriteLine();
                    }
                    else
                    Console.Write("0{0:X} ", i);
                }

                else if(i>16)
                {                
                    Console.Write("{0:X} ", i);

                    if (i>17 && i%16 == 0)
                     Console.WriteLine();
                }
            }
            Console.WriteLine();
        }



    }
}
