namespace Places.Migrations.Identity
{
    using DataContext;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Places.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(Places.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Provinces.AddOrUpdate(
                                p => p.ProvinceCode, DummyData.getProvinces().ToArray());
            context.SaveChanges();

            context.Cities.AddOrUpdate(
                c => new { c.CityId, c.ProvinceCode }, DummyData.getCities(context).ToArray()
                );
            //c => new { c.CityName, c.ProvinceCode }, DummyData.getProvinces().ToArray());
        }
    }
}
