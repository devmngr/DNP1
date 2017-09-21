using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car(1600, 3500, 160));
            cars.Add(new Car(2200, 3500, 200));
            cars.Add(new Car(1800, 3500, 150));
            cars.Add(new Car(2000, 3500, 180));   
            cars.Add(new Car(1900, 3500, 160));


            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }


            cars.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted list");

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }





        }
    }
}
