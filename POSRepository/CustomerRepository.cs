using POSData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRepository
{
    public class CustomerRepository
    {
        private POSEntities _db;

        //Database instance
        public CustomerRepository()
        {
            _db = new POSEntities();
        }

        //Add Customer
        public void AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        //Remove Customer
        public void RemoveCustomer(int customerId)
        {
            var customer = _db.Customers.FirstOrDefault(a => a.CustomerId == customerId);

            if (customer != null)
            {
                _db.Customers.Remove(customer);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Customer not found.");
            }
        }

        //Update Customer
        public Customer UpdateCustomer(Customer customer)
        {
            return null;
        }

        //Get by ID from Customer
        public Customer GetCustomer(int customerId)
        {
            return _db.Customers.FirstOrDefault(a => a.CustomerId == customerId);
        }

        //Get all Customers
        public List<Customer> GetCustomers()
        {
            return _db.Customers.ToList();
        }
    }
}
