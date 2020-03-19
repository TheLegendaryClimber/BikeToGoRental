namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewPropertiesToBike : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "Type", c => c.String());
            AddColumn("dbo.Bikes", "Model", c => c.String());
            AddColumn("dbo.Bikes", "Gears", c => c.Int(nullable: false));
            AddColumn("dbo.Bikes", "FrameSize", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "FrameSize");
            DropColumn("dbo.Bikes", "Gears");
            DropColumn("dbo.Bikes", "Model");
            DropColumn("dbo.Bikes", "Type");
        }
    }
}
