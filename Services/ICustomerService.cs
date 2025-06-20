using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects; // Assuming this namespace contains the Customer class
using Repositories; // Assuming this namespace contains the ICustomerRepository interface

namespace Services
{
    public interface ICustomerService
    {
        public void GenerateSampleData();
        public List<Customer> GetCustomers();
    }
}
