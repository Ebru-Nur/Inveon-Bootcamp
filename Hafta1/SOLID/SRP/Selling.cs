using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    class Selling
    {
        private int Id { get; set; }
        private int Count { get; set; }//sales count

        private Product Product { get; set; }


        public Selling(  int Count, Product Product)
        {
            this.Count = Count;
            this.Product = Product;
        }
    }
}
