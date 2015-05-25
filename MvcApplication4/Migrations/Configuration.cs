namespace MvcApplication4.Migrations
{
    using MvcApplication4.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcApplication4.Models.PlayerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcApplication4.Models.PlayerDBContext context)
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
            context.Players.AddOrUpdate(i => i.CName,
                new Player
                {
                    CName = "Justin",
                    Birthday = DateTime.Parse("1975-01-01"),
                    Email = "justin@lccnet.com",
                    Mobile = "0972199299",
                    Rating = "A"
                },
                new Player
                {
                    CName = "Andy",
                    Birthday = DateTime.Parse("1988-01-01"),
                    Email = "andy@yahoo.com",
                    Mobile = "0935000112",
                    Rating = "A"
                },
                new Player
                {
                    CName = "Jeff",
                    Birthday = DateTime.Parse("1988-01-01"),
                    Email = "andy@yahoo.com",
                    Mobile = "0935000112",
                    Rating = "B"
                },
                 new Player
                {
                    CName = "Claire",
                    Birthday = DateTime.Parse("1988-01-01"),
                    Email = "claire@yahoo.com",
                    Mobile = "0936369369",
                    Rating = "C"
                },
                new Player
                {
                    CName = "Fred",
                    Birthday = DateTime.Parse("1988-01-01"),
                    Email = "fred@yahoo.com",
                    Mobile = "0938986996",
                    Rating = "A"
                }
            );
        }
    }
}
