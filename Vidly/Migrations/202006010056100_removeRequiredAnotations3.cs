namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeRequiredAnotations3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: true));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: true));
            AddColumn("dbo.Movies", "NumerIsStock", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumerIsStock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
