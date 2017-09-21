using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBusTaxes 
{
    class Bus : Vehicle,ITaxable
    {

        protected int numberOfSeats;
        public Bus(int registrationNumber, double maxVelocity, decimal value,int  numberOfSeats) : base (registrationNumber,maxVelocity,value)
        {
            this.numberOfSeats = numberOfSeats;

        }
        public decimal TaxValue()
        {
            return 20;
        }
    }
}
