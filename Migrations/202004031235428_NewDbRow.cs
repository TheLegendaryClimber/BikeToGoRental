namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDbRow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DateRented = c.DateTime(nullable: false),
                    DateReturned = c.DateTime(),
                    BikeId = c.Int(nullable: false),
                    CustomerId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bikes", t => t.BikeId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.BikeId)
                .Index(t => t.CustomerId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Rentals", "BikeId", "dbo.Bikes");
            DropIndex("dbo.Rentals", new[] { "CustomerId" });
            DropIndex("dbo.Rentals", new[] { "BikeId" });
            DropTable("dbo.Rentals");
        }
    }
}
