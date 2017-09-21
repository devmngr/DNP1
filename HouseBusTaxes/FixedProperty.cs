using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBusTaxes
{
    class FixedProperty
    {
        protected string location { get; set; }
        protected bool inCity { get; set; }
        protected decimal estimatedValue { get; set; }


        public FixedProperty(string location,bool inCity, decimal estimatedValue)
        {
            this.location = location;
            this.inCity = inCity;
            this.estimatedValue = estimatedValue;
        }






    }
}
