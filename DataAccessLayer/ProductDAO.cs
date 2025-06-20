using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();
        public void GenerateSampleData()
        {
            products.Add(new Product { Id = 1, Name = "Laptop", Quantity=2,Price = 999.99F });
            products.Add(new Product { Id = 2, Name = "Smartphone", Quantity = 3, Price = 499.99F });
            products.Add(new Product { Id = 3, Name = "Tablet", Quantity = 4, Price = 299.99F});
            products.Add(new Product { Id = 4, Name = "Smartwatch", Quantity = 1, Price = 199.99F });
            products.Add(new Product { Id = 5, Name = "Headphones", Quantity = 9, Price = 89.99F });
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public bool SaveProduct(Product product)
        {
            Product old = products.FirstOrDefault(p=> p.Id == product.Id);
            if (old != null)
            {
                return false;//vì trùng mã nên không phải thêm mới
            }
            products.Add(product);
            return true; //thêm mới thành công
        }
    }
}
