using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.SRP
{
    class ProductServiceWithoutSRP
    {
        public List<Product> Products { get; set; }
        public List<Selling> Sales { get; set; }

        public void addProduct(int id, string name, double price)
        {
            Product product = new Product(name, price);
            Products.Add(product);


        }
        public void deleteProduct(Product product)
        {
            Products.Remove(product);

        }

        public void makeSale(int count, Product product)
        {
            Selling selling = new Selling(count, product);
            Sales.Add(selling);
        }

    }
}
