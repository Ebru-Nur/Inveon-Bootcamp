using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.ISP.WithISP
{
    internal interface IContractedEmployee: IWorker
    {
        double HourlyRate { get; set; }
        double HoursInMonth { get; set; }
        double CalculateWorkedSalary();
    }
}
