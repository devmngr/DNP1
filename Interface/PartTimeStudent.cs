using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class PartTimeStudent : PartTimeEmployee, IStudent
    {

        private int startYear;
        public int Startyear
        {
            get { return startYear; }
            set { startYear = value; }
        }
        public PartTimeStudent(string name, double hourlyWage, int hoursPerMonth, int startYear) : 
            base(name, hourlyWage, hoursPerMonth)
        {
            register(startYear);

        }  

        public void register(int startYear)
        {
            this.startYear = startYear;
        }
    }
}
