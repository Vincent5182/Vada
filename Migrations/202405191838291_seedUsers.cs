namespace Vada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    // admin
    // peter@gmail.com
    // Pineapple1!

    // customer
    // jack@gmail.com
    // Pineapple1!
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5fbd9f80-030a-47ac-ae42-ff29906f7eba', N'jack@gmail.com', 0, N'AKMrRwgJ9+InFipcb8oZdbn9FDfM5d9dKG/ZqCJe/3PCq41Ltd+VrXlafSVQnhKhEw==', N'0119a0c2-59da-4b9d-8084-f95aae289ab7', NULL, 0, 0, NULL, 1, 0, N'jack@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fe317a65-34b1-44d4-9458-14bfbca0a903', N'peter@gmail.com', 0, N'AChcciC6beoYrLomk9TIa9XtvJlSym4gLLOO8p0EniUx0OpwqDINdDFb47YtMPrzhw==', N'3c74e3d9-5f00-4da9-a110-a291ea9314f1', NULL, 0, 0, NULL, 1, 0, N'peter@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'db38a2d7-f01e-402a-bf7d-f86b21f76e5d', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fe317a65-34b1-44d4-9458-14bfbca0a903', N'db38a2d7-f01e-402a-bf7d-f86b21f76e5d')
");

        }
        
        public override void Down()
        {
        }
    }
}
