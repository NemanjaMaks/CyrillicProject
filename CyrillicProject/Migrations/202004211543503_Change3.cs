namespace CyrillicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.APICalls", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.APICalls", "Date");
        }
    }
}
