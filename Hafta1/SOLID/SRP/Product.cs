using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    class Product
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private double Price { get; set; }

     public Product( string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
