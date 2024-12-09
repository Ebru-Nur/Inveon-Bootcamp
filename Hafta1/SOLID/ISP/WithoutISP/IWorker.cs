using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.ISP
{
    internal interface IWorker
    {
        string Id { get; set; }
        string Name { get; set; }
        double MonthlySalary { get; set; }
        double HourlyRate { get; set; }//saatlik ücret
        double HoursInMonth { get; set; } //aylık çalışma saati
        double CalculateNetSalary();
        double CalaculateWorkedSalary();
    }
}
