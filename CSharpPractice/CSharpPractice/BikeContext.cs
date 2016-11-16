namespace CSharpPractice
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Linq;

    class BikeContext : DbContext
    {
        // Your context has been configured to use a 'BikeContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CSharpPractice.BikeContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BikeContext' 
        // connection string in the application configuration file.
        public BikeContext()
            : base("name=BikeContext")
        {
            Database.SetInitializer<BikeContext>(new DropCreateDatabaseAlways<BikeContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bike>()
                .Property(x => x.BikeName)
                .HasMaxLength(20)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(
                    new IndexAttribute("IX_BikeName", 1) { IsUnique = true })
                    );
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}