using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.ISP.WithISP
{
    internal interface IWorker
    {
        string ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }
}
