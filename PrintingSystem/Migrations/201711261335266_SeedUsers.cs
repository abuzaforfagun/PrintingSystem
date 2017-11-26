namespace PrintingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0120b00a-b385-48ee-ad72-536fb8df5605', N'Admin')
                INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'83afd6e2-7738-4524-97dd-03cb5d5cf6d5', N'User')
                INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name]) VALUES (N'555e9bb2-ead2-423b-9c6b-88288221aa76', N'admin@printingsystem.com', 0, N'ABym8BNVe8uTrRd3nycU4iNyJaatop+ilDcBaIXULUAgfoOukdYZVhyAp4/bSc+fHg==', N'4a83f38a-b97b-40de-af29-cccf5078f79e', NULL, 0, 0, NULL, 1, 0, N'admin@printingsystem.com', N'admin')
                INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'555e9bb2-ead2-423b-9c6b-88288221aa76', N'0120b00a-b385-48ee-ad72-536fb8df5605')
");
        }
        
        public override void Down()
        {
            Sql(@"
                Delete from [dbo].[AspNetRoles] where id in ('0120b00a-b385-48ee-ad72-536fb8df5605', '83afd6e2-7738-4524-97dd-03cb5d5cf6d5')
                Delete from [dbo].[AspNetUsers] where id = '555e9bb2-ead2-423b-9c6b-88288221aa76'
                Delete from [dbo].[AspNetUserRoles] where userid = '555e9bb2-ead2-423b-9c6b-88288221aa76'
            ");
        }
    }
}
