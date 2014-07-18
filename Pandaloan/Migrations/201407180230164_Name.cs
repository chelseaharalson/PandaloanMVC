namespace Pandaloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "firstname", c => c.String());
            AddColumn("dbo.Users", "lastname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "lastname");
            DropColumn("dbo.Users", "firstname");
        }
    }
}
