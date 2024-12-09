using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
   public class DirectorWithoutOCP
    {
        public int id { get; set; }
        public double hourlyWage { get; set; } //saatlik ücret
        public double Time { get; set; } //çalışma süresi

        public DirectorWithoutOCP(double hourlyWage, double Time)
        {
            this.hourlyWage = hourlyWage;
            this.Time = Time;
        }
    }
}
