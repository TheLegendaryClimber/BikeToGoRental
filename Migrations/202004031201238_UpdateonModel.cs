namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateonModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "CustomerId", c => c.Byte(nullable: false));
            AddColumn("dbo.Rentals", "BikeId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "BikeId");
            DropColumn("dbo.Rentals", "CustomerId");
        }
    }
}
