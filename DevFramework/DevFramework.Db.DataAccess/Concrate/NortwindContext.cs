using DevFramework.Db.DataAccess.Concrate.EnttityFramework.Mappings;
using DevFramework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.DataAccess.Concrate
{
   
    public class NortwindContext:DbContext
    {
        public NortwindContext()
        {
            Database.SetInitializer<NortwindContext>(null);
        }

      public  DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }

    }
}
