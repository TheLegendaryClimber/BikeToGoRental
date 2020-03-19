namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGearsModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bikes", "Gears", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bikes", "Gears", c => c.Int(nullable: false));
        }
    }
}
