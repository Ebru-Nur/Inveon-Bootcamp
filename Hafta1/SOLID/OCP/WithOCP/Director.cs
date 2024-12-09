using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    public class Director : IEmployee
    {
        private int Id { get; set; }
        private double Time { get; set; } //çalışma süresi

        public Director(double Time)
        {
            this.Time = Time;
        }

        public double CalculateSalary()
        {
            const double hourlyWage = 400; //saatlik ücret
            return hourlyWage * Time;
        }
    }
}
