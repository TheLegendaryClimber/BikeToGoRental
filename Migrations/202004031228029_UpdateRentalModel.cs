namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRentalModel : DbMigration
    {
        public override void Up()
        {
         
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "BikeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Rentals", "CustomerId", c => c.Byte(nullable: false));
        }
    }
}
