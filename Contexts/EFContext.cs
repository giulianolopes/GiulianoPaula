using Giuliano.Paula.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Giuliano.Paula.Contexts
{
    public class EFContext : DbContext

    {
        public EFContext() : base("Asp_Net_MVC_CS")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers  { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}