using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_Control_Application.Orm.Entity;

namespace Stock_Control_Application.Orm.Context
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=StockControlApplication;uid=sa;pwd=1453";
        }

        // Migration steps
        // enable-migrations
        // add-migration 'a'
        // update-database

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Salle> Salles { get; set; }

    }
}
