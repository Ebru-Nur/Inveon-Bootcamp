using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    class SellingService
    {
        public List<Selling> Sales { get; set; }
      
 
        public void makeSale(int count, Product product)
        {

            Selling selling = new Selling(count, product);
            Sales.Add(selling);
        }
    }
}
