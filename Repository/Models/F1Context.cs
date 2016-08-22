using F1Repository.IRepository;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Repository.Models
{
    public class F1Context : IdentityDbContext, IF1Context
    {
        public F1Context()
            : base("DefaultConnection")
        {
        }

        public static F1Context Create()
        {
            return new F1Context();
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
