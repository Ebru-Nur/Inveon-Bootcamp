using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    class SalaryWithoutOCP
    {
        public double CalculateDirectorSalary(DirectorWithoutOCP director)
        {
            return director.hourlyWage* director.Time;
        }

        public double CalculateWorkerSalary(WorkerWithoutOCP worker)
        {
            return worker.HourlyWage * worker.Time;
        }
    }

 
}
