namespace NorthwindProject.DataAccess.Concrete.EntityFramework.Contexts
{
    using NorthwindProject.DataAccess.Concrete.EntityFramework.Mappings;
    using NorthwindProject.Entities.Concrete;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NorthwindContext : DbContext
    {
        // Your context has been configured to use a 'NorthwindContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'NorthwindProject.DataAccess.Concrete.EntityFramework.Contexts.NorthwindContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'NorthwindContext' 
        // connection string in the application configuration file.
        public NorthwindContext()
            : base("name=NorthwindContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Category> Categories;
        public DbSet<Product> Products;
        public DbSet<User> Users;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}