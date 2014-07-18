namespace Pandaloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        password = c.String(),
                        address1 = c.String(),
                        address2 = c.String(),
                        city = c.String(),
                        state = c.String(),
                        zipcode = c.String(),
                        lastlogin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
