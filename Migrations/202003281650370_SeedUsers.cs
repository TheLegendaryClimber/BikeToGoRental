namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'594cc43e-3fe8-413b-8ef2-3a4bac800359', N'sailor1997@abv.bg', 0, N'ADqsobgQf1xMuAQM4+/QKGy5dSOn8GNbmq81v9gjNishz9qCiKUhGo8kJDkWwVmH1w==', N'16aeee4c-6335-494d-9cfe-8eb64421377c', NULL, 0, 0, NULL, 1, 0, N'sailor1997@abv.bg')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8b6f95a7-c059-4014-92f2-ca5027186164', N'admin@biketogo.com', 0, N'AI83UMRWNyI1oSo3wSYp0zcReJzRFxG4aBvmxLCOMrJBEi/qNulniJnayii+nbnqnA==', N'65d51fbe-d443-4625-b961-7a9ae5270f89', NULL, 0, 0, NULL, 1, 0, N'admin@biketogo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c66215b5-e411-44d4-9254-49a1fc1c8991', N'guest@biketogo.com', 0, N'AEwc+1606dWKuvn60Cbdjb4pxCkJFEk6HlxuykzjfBbuAn73PGp9AzPtlM8pjIspkA==', N'579ba006-277b-48e4-8d36-85ea8d01c8be', NULL, 0, 0, NULL, 1, 0, N'guest@biketogo.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'196e2bb7-c61f-4a3d-8bda-eff9fc1568a5', N'CanManageBikes')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8b6f95a7-c059-4014-92f2-ca5027186164', N'196e2bb7-c61f-4a3d-8bda-eff9fc1568a5')


");
        }
        
        public override void Down()
        {
        }
    }
}
