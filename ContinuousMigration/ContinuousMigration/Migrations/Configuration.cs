namespace ContinuousMigration.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContinuousMigration.Models.ZmaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ContinuousMigration.Models.ZmaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //zhendong: use AddOrUpdate to check see if a student with name specified exists as a new record,
            //if it does not then reated it, if it does, then update the major specified, also could add more schema 
            context.Students.AddOrUpdate(
              p => p.name,
              new Student { name = "Andrew Peters", major="Math" },
              new Student { name = "Brice Lambson", major="CS"},
              new Student { name = "Rowan Miller", major="Dance"}
            );

        }
    }
}
