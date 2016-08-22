using F1Repository.IRepository;
using F1Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Repository.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly F1Context _db;
        public CustomerRepository(F1Context db)
        {
            _db = db;
        }

        public IQueryable<Customer> GetCustomers()
        {
            var customers = _db.Customers;
            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            Customer customer = _db.Customers.Find(id);
            return customer;
        }

        public void AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
        }

        public void EditCustomer(Customer customer)
        {
            _db.Entry(customer).State = EntityState.Modified;
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = _db.Customers.Find(id);
            _db.Customers.Remove(customer);

        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }


    }
}
