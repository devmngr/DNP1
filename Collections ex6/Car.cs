using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_ex6
{
    class Car : IComparable<Car>
    {
        private int engineSize { get; set; }
        private double weight { get; set; }
        private int topSpeed { get; set; }

        public Car(int engineSize, double weight, int topSpeed)
        {
            this.engineSize = engineSize;
            this.weight = weight;
            this.topSpeed = topSpeed;
        }



        public override string ToString()
        {
            string temp = "Engine Size = " + engineSize +" Weight = "+ weight+ " TopSpeed = " + topSpeed;
            return temp;
        }
        public int CompareTo(Car other)
        {
            if (other.engineSize > engineSize)
                return 1;
            else if (other.engineSize < engineSize)
                return -1;

            else return 0;

        }




        /*
        public int CompareTo(Car other)
        {
            if (other.topSpeed > topSpeed)
                return 1;
            else if (other.topSpeed < topSpeed)
                return -1;

            else return 0;

        }
        */
    }
}
