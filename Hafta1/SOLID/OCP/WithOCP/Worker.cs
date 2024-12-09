using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    public class Worker : IEmployee
    {
        private int id { get; set; }
        private double time { get; set; } //çalışma süresi

        public Worker(double time)
        {
            this.time = time;
        }

        public double CalculateSalary()
        {
            const double hourlyWage = 200; //saatlik ücret
            return hourlyWage * time;
        }
    }
}
