using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.ISP
{
    internal class FullTimeEmployee : IWorker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double MonthlySalary { get; set; }
        public double HourlyRate { get; set; }
        public double HoursInMonth { get; set; }
        public double CalculateNetSalary()
        {
            return MonthlySalary;
        }
        public double CalaculateWorkedSalary() {
            throw new NotImplementedException();
        }
    } 


    }
