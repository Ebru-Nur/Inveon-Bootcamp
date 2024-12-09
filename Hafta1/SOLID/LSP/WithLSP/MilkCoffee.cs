using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.LSP.WithLSP
{
    // Süt eklenebilen kahve türleri
    public abstract class MilkCoffee : Coffee
    {
        public override void grindCoffeeBeans() {

        }
        public abstract void AddMilk();

    }
}
