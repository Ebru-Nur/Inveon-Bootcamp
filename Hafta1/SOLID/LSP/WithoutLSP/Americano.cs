using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.LSP.WithoutLSP
{
    internal class Americano: Coffee
    {
        public void AddMilk()
        {
            throw new NotImplementedException("Americano süt içermez.");
        }
    }
}
