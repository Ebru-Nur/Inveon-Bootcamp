using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.LSP.WithoutLSP
{
    public class Coffee
    {
        public String milk { get; set; }
        public String coffee { get; set; }
        public void grindCoffeeBeans()
        {
            Console.WriteLine("Kahve çekirdekleri öğütülüyor.");
        }

        public void addMilk()
        {
            Console.WriteLine("Süt ekleniyor.");
        }
    }
}
