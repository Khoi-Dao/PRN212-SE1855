using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ2Object2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
            
        }
        public void gen_products()
        {
            products.Add(new Product { Id = 1, Name = "Product1", Quantity = 10, Price = 100.0 });
            products.Add(new Product { Id = 2, Name = "Product2", Quantity = 20, Price = 200.0 });
            products.Add(new Product { Id = 3, Name = "Product3", Quantity = 30, Price = 300.0 });
            products.Add(new Product { Id = 4, Name = "Product4", Quantity = 40, Price = 400.0 });
            products.Add(new Product { Id = 5, Name = "Product5", Quantity = 50, Price = 500.0 });
            products.Add(new Product { Id = 6, Name = "Product6", Quantity = 60, Price = 600.0 });
            products.Add(new Product { Id = 7, Name = "Product7", Quantity = 70, Price = 700.0 });
            products.Add(new Product { Id = 8, Name = "Product8", Quantity = 80, Price = 800.0 });
            products.Add(new Product { Id = 9, Name = "Product9", Quantity = 90, Price = 900.0 });
            products.Add(new Product { Id = 10, Name = "Product10", Quantity = 1000, Price = 1000.0 });
        }
        public List<Product> FilterProductsByPrice (double price1, double price2)
        {
            return products.Where(p =>p.Price >= price1 && p.Price <= price2)
                .ToList();
        }
        public List<Product> FilterProductsByQuerySyntax (double price1 , double price2)
        {
            var query = from p in products
                        where p.Price>= price1 && p.Price <= price2
                        select p;
            return query.ToList();
        }
        public List<Product> SortProductsByPriceDescending()
        {
            return products.OrderByDescending(p => p.Price)
                .ToList();
        }
        public List<Product> SortProductsByPriceDescendingQuerySyntax()
        {
            var query = from p in products
                        orderby p.Price descending
                        select p;
            return query.ToList();
        }
        public double SumOfValue()
        {
            return products.Sum(p => p.Quantity * p.Price);
        }
    }
}
