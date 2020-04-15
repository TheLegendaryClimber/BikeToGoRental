namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPictureToBikeModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "BikeImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "BikeImage");
        }
    }
}
