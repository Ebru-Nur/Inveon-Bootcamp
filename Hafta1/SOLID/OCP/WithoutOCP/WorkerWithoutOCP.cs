using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
   public class WorkerWithoutOCP
    {
        public int Id { get; set; }
        public double HourlyWage { get; set; } //saatlik ücret
        public double Time { get; set; } //çalışma süresi

        public WorkerWithoutOCP(double HourlyWage, double Time)
        {
            this.HourlyWage = HourlyWage;
            this.Time = Time;
        }
    }
}
