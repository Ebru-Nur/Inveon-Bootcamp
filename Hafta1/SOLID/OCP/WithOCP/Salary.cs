using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    public class Salary
    {

      public double CalculateTotalSalary(IEmployee[] employees)
        {
            double totalSalary = 0;
            foreach (var employee in employees)
            {
                totalSalary += employee.CalculateSalary();
            }
            return totalSalary;
        }

    }
}


