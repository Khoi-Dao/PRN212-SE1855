using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects; // Assuming this namespace contains the Customer class

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        List<Customer> customers = new List<Customer>();
        public void GenerateSampleData()
        {
            customers.Add(new Customer { Id = 1, Name = "John Doe", Phone = "123-456-7890" });
            customers.Add(new Customer { Id = 2, Name = "Jane Smith", Phone = "987-654-3210" });
            customers.Add(new Customer { Id = 3, Name = "Alice Johnson", Phone = "555-555-5555" });
            customers.Add(new Customer { Id = 4, Name = "Bob Brown", Phone = "444-444-4444" });
            customers.Add(new Customer { Id = 5, Name = "Charlie White", Phone = "333-333-3333" });
        }
        public List<Customer> GetCustomers() {
            return customers;
        }
    }
}