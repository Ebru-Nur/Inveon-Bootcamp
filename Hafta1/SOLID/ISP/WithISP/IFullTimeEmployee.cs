using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.ISP.WithISP
{
    internal interface IFullTimeEmployee : IWorker
    {
        double MonthlySalary { get; set; }
        double OtherBenefits { get; set; }
        double CalculateNetSalary();
    }
}
