using NorthwindProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).IsRequired()
                .HasMaxLength(15)
                .HasColumnName("Name");
            //intentionall left Description mapping out to see what happens
            HasMany(t => t.Products).WithOptional(t => t.Category);
        }

    }
}
