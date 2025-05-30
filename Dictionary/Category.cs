using OOP5_Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Generic_Collection
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category() {
            Products = new Dictionary<int, Product>();
        }
        //làm đủ CRUD
        public void AddProduct(Product p)
        {
            if (!Products.ContainsKey(p.Id))
            {
                Products.Add(p.Id, p);
            }
            else
            {
                Console.WriteLine("Product with this ID already exists.");
                return;
            }
        }
        // Xem toàn bộ products trong category
        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p =item.Value;
                //Console.WriteLine($"ID: {item.Value.Id}, Name: {item.Value.Name}, Quantity: {item.Value.Quantity}, Price: {item.Value.Price}");
                Console.WriteLine(p);
            }
        }
        // lọc ra các sp có giá từ x tới y
        public Dictionary<int, Product> FilterProductByPrice( double min, double max)
        {
            Dictionary<int, Product> results = new Dictionary<int, Product>(); // tại sao? lại khai báo lại
            results = Products.Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();
            return results;
        }
        // sấp xếp sp theo giá tăng dần
        public Dictionary<int, Product> SortProductByPriceAscending()
        {
            return Products.OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }
        //sấp xếp sp theo đơn gia tăng dần
        // nếu đơn giá trùng nhau thì sấp xếp theo số lượng giảm dần
        public Dictionary<int, Product> ComplexSort()
        {
            return Products.OrderBy(item => item.Value.Price )
                .ThenByDescending(item => item.Value.Quantity)
                .ToDictionary<int, Product>();
        }
        //update product
        public bool UpdateProduct(Product p)
        {
            if (p == null) return false;
            if (Products.ContainsKey(p.Id) == false)
                return false;
            Products[p.Id] = p; // đè dữ liệu lên ô nhớ hiện tại 
            //hoặc tham chiếu tới ô nhớ khác
            return true;

        }
        public bool DeleteProduct(int id)
        {
            if (Products.ContainsKey(id)== false)
            {
                return false;
                
            }
            return Products.Remove(id);
        }
    }
}
