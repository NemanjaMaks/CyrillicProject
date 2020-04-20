namespace CyrillicProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.APICalls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Request = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.APICalls");
        }
    }
}
