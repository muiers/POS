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
            var repo = new ItemRepository();
            var item = new Item
            {
                Name = "Street Light",
                Price = 100,
                IsActive = true,
                ItemCategoryId = 1
            };

            repo.AddItem(item);
            
            //var customerRepo = new CustomerRepository();
            //var customer = new Customer
            //{
            //    Name = "Rachel Green",
            //    ContactNumber = "11111111",
            //    Address = "NY",
            //};

            //customerRepo.AddCustomer(customer);

            //var customers = customerRepo.GetCustomers();

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"Customer Name: { item.Name}");
            //}

            //var customer = customerRepo.GetCustomer(1);

            //Console.WriteLine($"Customer Name: { customer.Name}");


            Console.ReadKey();
        }
    }
}
