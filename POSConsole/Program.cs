using POSData;
using POSRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSConsoleTestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerRepo = new CustomerRepository();
            var customer = new Customer
            {
                Name = "Rachel Green",
                ContactNumber = "11111111",
                Address = "NY",
            };

            customerRepo.AddCustomer(customer);
            
            Console.ReadKey();
        }
    }
}
