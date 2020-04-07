namespace BikeToGoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingRolesAndUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [Birthdate]) VALUES (N'8b6f95a7-c059-4014-92f2-ca5027186164', N'admin@biketogo.com', 0, N'AI83UMRWNyI1oSo3wSYp0zcReJzRFxG4aBvmxLCOMrJBEi/qNulniJnayii+nbnqnA==', N'65d51fbe-d443-4625-b961-7a9ae5270f89', NULL, 0, 0, NULL, 1, 0, N'admin@biketogo.com', N'Admin', N'Admin', N'1900-01-01 00:00:00')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [Birthdate]) VALUES (N'b65acf83-9939-432d-9399-cb5b3e0c2dab', N'guest@biketogo.com', 0, N'AEQDEklQG2rI3f7YvVqnej9Q+tBwONxtFQ/IkRlWaqILKai6MCEFnnBMmg6nePZBcw==', N'd4293653-e002-408f-8108-8def5a9e46f6', NULL, 0, 0, NULL, 1, 0, N'guest@biketogo.com', N'Guest', N'Guest', N'1980-01-01 00:00:00')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'196e2bb7-c61f-4a3d-8bda-eff9fc1568a5', N'CanManageBikes')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e0687463-cbb5-40e5-a8bd-77f154711849', N'CanManageCustomers')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5d45ea54-3ce2-40b1-a6c0-8b4390381d0a', N'CanManageRentals')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8b6f95a7-c059-4014-92f2-ca5027186164', N'196e2bb7-c61f-4a3d-8bda-eff9fc1568a5')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8b6f95a7-c059-4014-92f2-ca5027186164', N'e0687463-cbb5-40e5-a8bd-77f154711849')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8b6f95a7-c059-4014-92f2-ca5027186164', N'5d45ea54-3ce2-40b1-a6c0-8b4390381d0a')

");
        }
        
        public override void Down()
        {
        }
    }
}
