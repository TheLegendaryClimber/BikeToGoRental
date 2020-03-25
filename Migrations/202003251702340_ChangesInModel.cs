namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bikes", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bikes", "Name", c => c.String());
        }
    }
}
