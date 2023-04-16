namespace Seesion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        username = c.String(maxLength: 10, fixedLength: true),
                        password = c.String(maxLength: 10, fixedLength: true),
                        name = c.String(maxLength: 10, fixedLength: true),
                        rol = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Account");
        }
    }
}
