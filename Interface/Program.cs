using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Company company = new Company();
                company.employNewEmployee(new FullTimeEmployee("bogdan", 14000));
                company.employNewEmployee(new PartTimeEmployee("Denisa", 140, 160));

                Console.WriteLine("{0:n}", company.getMonthlySalaryTotal());
                company.employNewEmployee(new PartTimeStudent("Kim", 250, 90, 2003));

            Console.WriteLine("{0:n}", company.getMonthlySalaryTotal());

        }
    }
}
