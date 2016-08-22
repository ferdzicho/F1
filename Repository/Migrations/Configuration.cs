namespace F1Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<F1Repository.Models.F1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(F1Repository.Models.F1Context context)
        {
            if (context.Customers.Count() == 0)
            {
                context.Customers.AddOrUpdate(
                  new Models.Customer { Name = "Grupa Kotrak", ShortName = "Grupa Kotrak", Address = "Parczewskiego 25", City = "Katowice", PostalCode = "40-582", Nip = "6455554554" }
                );
            }
        }
    }
}
