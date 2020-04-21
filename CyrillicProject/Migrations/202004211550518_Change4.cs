namespace CyrillicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.APICalls", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.APICalls", "Username");
        }
    }
}
