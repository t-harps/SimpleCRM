namespace SimpleCRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        NameOrNum = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        Postcode = c.String(),
                        County = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Address", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Address", new[] { "CustomerID" });
            DropTable("dbo.Customer");
            DropTable("dbo.Address");
        }
    }
}
