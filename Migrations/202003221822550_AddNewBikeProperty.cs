namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewBikeProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "AmountInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "AmountInStock");
        }
    }
}
