using DevFramework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.DataAccess.Concrate.EnttityFramework.Mappings
{
  public  class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.CategoryID);
         
            Property(x => x.CategoryID).HasColumnName("CategoryID");
      
            Property(x => x.CategoryName).HasColumnName("CategoryName");

        }
    }
}
