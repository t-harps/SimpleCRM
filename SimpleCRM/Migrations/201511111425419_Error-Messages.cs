namespace SimpleCRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ErrorMessages : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Address", "Postcode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Address", "Postcode", c => c.String());
        }
    }
}
