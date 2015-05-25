namespace MvcApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Rating", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Rating");
        }
    }
}
