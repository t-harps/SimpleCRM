namespace SimpleCRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Address", "NameOrNum", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Address", "AddressLine1", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Address", "County", c => c.String(nullable: false));
            AlterColumn("dbo.Address", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customer", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customer", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Gender", c => c.String());
            AlterColumn("dbo.Customer", "LastName", c => c.String());
            AlterColumn("dbo.Customer", "FirstName", c => c.String());
            AlterColumn("dbo.Customer", "Email", c => c.String());
            AlterColumn("dbo.Address", "Country", c => c.String());
            AlterColumn("dbo.Address", "County", c => c.String());
            AlterColumn("dbo.Address", "AddressLine1", c => c.String());
            AlterColumn("dbo.Address", "NameOrNum", c => c.String());
        }
    }
}
