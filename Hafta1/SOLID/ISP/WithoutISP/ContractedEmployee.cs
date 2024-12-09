using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.ISP.WithoutISP
{
    internal class ContractedEmployee : IWorker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double MonthlySalary { get; set; }
        public double HourlyRate { get; set; }
        public double HoursInMonth { get; set; }
        public double CalculateNetSalary()
        {
            throw new NotImplementedException();
        }
        public double CalaculateWorkedSalary()
        {
            return HourlyRate * HoursInMonth;
        }
    }
}
