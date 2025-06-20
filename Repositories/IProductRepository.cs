using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects; // Assuming this namespace contains the Customer class
namespace Repositories
{
    public interface IProductRepository
    {
        public void GenerateSampleData();
        public List<Product> GetProducts();
        public bool SaveProduct(Product product);
    }
}
