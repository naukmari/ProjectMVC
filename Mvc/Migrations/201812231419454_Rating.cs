namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Rating");
        }
    }
}
