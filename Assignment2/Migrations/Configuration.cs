namespace Assignment2.Migrations
{
    using Assignment2.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment2.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            context.Customers.AddOrUpdate(
               new Models.Customer() { Id = 1, Name = "Shital",Email="ssbhutiya@gmail.com" }
            );
            context.Employees.AddOrUpdate(
               new Models.Employee() { Id = 1, Name = "Jass", RegistrationNumber =123456 }
            );
            context.Products.AddOrUpdate(
               new Models.Product() { Id = 1, Name = "Mouse", Quantity=10,price=123 }
            );
            context.StoreLocations.AddOrUpdate(
               new Models.StoreLocation() { Id = 1,LocationName="South"  }
            );
        }
    }
}
