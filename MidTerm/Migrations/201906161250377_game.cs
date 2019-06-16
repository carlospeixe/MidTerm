namespace MidTerm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class game : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Name", c => c.String());
            DropColumn("dbo.Games", "Developer");
            DropColumn("dbo.Games", "Reviews");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Reviews", c => c.Int(nullable: false));
            AddColumn("dbo.Games", "Developer", c => c.String());
            DropColumn("dbo.Games", "Name");
        }
    }
}
