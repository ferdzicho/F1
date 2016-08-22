using F1Repository.Models;
using System.Linq;

namespace F1Repository.Repository
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetCustomers();
        Customer GetCustomerById(int id);

        void DeleteCustomer(int id);
        
        void AddCustomer(Customer customer);
        void EditCustomer(Customer customer);

        void SaveChanges();
        
    }
}