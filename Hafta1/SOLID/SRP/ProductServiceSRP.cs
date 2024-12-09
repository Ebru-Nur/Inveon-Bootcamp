using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    class ProductServiceSRP
    {
        public List<Product> Products { get; set; }
     

        public void addProduct(int id, string name, double price)
        {
            Product product = new Product(name, price);
            Products.Add(product);


        }
        public void deleteProduct(Product product)
        {
            Products.Remove(product);

        }


    }
}
