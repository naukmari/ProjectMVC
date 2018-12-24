namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Products", "Category", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "Rating", c => c.String(maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Rating", c => c.String());
            AlterColumn("dbo.Products", "Category", c => c.String());
            AlterColumn("dbo.Products", "Title", c => c.String());
        }
    }
}
