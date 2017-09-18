using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Company
    {
        private List<Employee> employs = new List<Employee>();


        public void employNewEmployee(Employee employee)
        {
            employs.Add(employee);
        }

        public double getMonthlySalaryTotal()
        {

            double total = 0;

            foreach(Employee item in employs)
            {
                total += item.getMonthSalary();
            }
            return total;
        }



    }
}
