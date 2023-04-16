namespace Seesion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRolToPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Rol", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Rol");
        }
    }
}
