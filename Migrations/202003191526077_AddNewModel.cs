namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SurfaceTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Bikes", "SurfaceTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Bikes", "SurfaceTypeId");
            AddForeignKey("dbo.Bikes", "SurfaceTypeId", "dbo.SurfaceTypes", "Id", cascadeDelete: true);
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bikes", "SurfaceType", c => c.String());
            DropForeignKey("dbo.Bikes", "SurfaceTypeId", "dbo.SurfaceTypes");
            DropIndex("dbo.Bikes", new[] { "SurfaceTypeId" });
            DropColumn("dbo.Bikes", "SurfaceTypeId");
            DropTable("dbo.SurfaceTypes");
        }
    }
}
