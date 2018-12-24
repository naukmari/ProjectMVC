namespace Mvc.Migrations
{
    using Mvc.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc.Models.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mvc.Models.ProductDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(i => i.Title,
        new Product
        {
            Title = "Sunshine",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Category = "Paintings",
            Price = 700,
            Rating = "High"

        },

         new Product
         {
             Title = "Ghost house",
             ReleaseDate = DateTime.Parse("1984-3-13"),
             Category = "Paintings",
             Price = 1000,
             Rating = "Middle"

         },

         new Product
         {
             Title = "Reno Logan",
             ReleaseDate = DateTime.Parse("1986-2-23"),
             Category = "Cars",
             Price = 1000000,
             Rating = "High"
         },

       new Product
       {
           Title = "Wedding gray dress",
           ReleaseDate = DateTime.Parse("2018-4-15"),
           Category = "Clothes",
           Price = 300,
           Rating = "Middle"

       }
   );
        }
    }
}
