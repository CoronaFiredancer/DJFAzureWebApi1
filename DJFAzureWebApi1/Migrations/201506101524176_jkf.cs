namespace DJFAzureWebApi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jkf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JKFs", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JKFs", "Name");
        }
    }
}
