using NorthwindProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Name).IsRequired().HasMaxLength(40);
            Property(t => t.QuantityPerUnit).HasMaxLength(20);

            ToTable("Products");

            Property(t => t.Id).HasColumnName("ProductId");
            Property(t => t.Name).HasColumnName("ProductName");
            Property(t => t.CategoryId).HasColumnName("CategoryID");
            Property(t => t.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");

            HasOptional(t => t.Category).WithMany(t => t.Products)
                .HasForeignKey(t => t.CategoryId);
        }
    }
}
