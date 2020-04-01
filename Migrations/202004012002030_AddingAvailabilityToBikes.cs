namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAvailabilityToBikes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "AmountAvailable", c => c.Byte(nullable: false));

            Sql("UPDATE Bikes SET AmountAvailable = AmountInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AmountAvailable");
        }
    }
}
