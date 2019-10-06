namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0c6ab530-d449-404b-970c-2287677ef791', N'Guest@Vidly.com', 0, N'ALIsWchRie1uPnamfs3m37fgljMRYMPReugaN0iezDZkOv87EOIB0rOAzk66aHioUA==', N'942ec3ec-3419-43a8-8877-eba5aaf0f4f3', NULL, 0, 0, NULL, 1, 0, N'Guest@Vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c8f56ab0-feff-4b4f-b78d-2b7b805f36b0', N'admin@Vidly.com', 0, N'AI5Ad/3Cwqre1bjq7Io+a0xslkmFwSUr9CEzR15NC0gVJEthPFv1rCKiCrfZ1X1hAg==', N'e0051d58-ad3a-447a-a8e6-37e068490230', NULL, 0, 0, NULL, 1, 0, N'admin@Vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c203ac42-35a5-4d1f-ab78-56e2889412ba', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c8f56ab0-feff-4b4f-b78d-2b7b805f36b0', N'c203ac42-35a5-4d1f-ab78-56e2889412ba')

");
        }
        
        public override void Down()
        {
        }
    }
}
