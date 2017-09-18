using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class FullTimeEmployee : Employee
    {
        private double monthlySallary;
        public FullTimeEmployee(string name,double monthlySallary) :base(name)
        {
            this.monthlySallary = monthlySallary;
        }

        public override double getMonthSalary()
        {
            return monthlySallary;
        }
    }
}
