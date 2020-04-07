namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "Bike_Id", "dbo.Bikes");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Bike_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropPrimaryKey("dbo.Bikes");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Rentals");
            AlterColumn("dbo.Bikes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Rentals", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Rentals", "Bike_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "Customer_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Bikes", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.Rentals", "Id");
            CreateIndex("dbo.Rentals", "Bike_Id");
            CreateIndex("dbo.Rentals", "Customer_Id");
            AddForeignKey("dbo.Rentals", "Bike_Id", "dbo.Bikes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Rentals", "Bike_Id", "dbo.Bikes");
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropIndex("dbo.Rentals", new[] { "Bike_Id" });
            DropPrimaryKey("dbo.Rentals");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Bikes");
            AlterColumn("dbo.Rentals", "Customer_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Rentals", "Bike_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Rentals", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Bikes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Rentals", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.Bikes", "Id");
            CreateIndex("dbo.Rentals", "Customer_Id");
            CreateIndex("dbo.Rentals", "Bike_Id");
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "Bike_Id", "dbo.Bikes", "Id", cascadeDelete: true);
        }
    }
}
