using F1Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Repository.IRepository
{
    public interface IF1Context
    {

        DbSet<Customer> Customers { get; set; }
        int SaveChanges();
        Database Database { get; }

        DbEntityEntry Entry(object entity);
    }
}
