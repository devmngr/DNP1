using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
        public abstract class Employee
        {
            public string name { get; }

            public Employee(string name)
            {
                this.name = name;
            }
    
            public abstract double getMonthSalary();

        }
    
}
