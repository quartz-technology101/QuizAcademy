namespace QuizAcademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1aaa6e4d-9e2c-456f-98a1-bfe25b20b579', N'aayush@quizacademy.com', 0, N'AFWdoOOag1B0Vg0lt/oC6WRz8mjHEC7v6yHqLcqQk0vf4FcEfqrmM3aelBDyO41Oeg==', N'479d5d64-5245-47a8-b738-7fb57a55fced', NULL, 0, 0, NULL, 1, 0, N'aayush@quizacademy.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'573de45c-d173-48a0-9a15-938e9d7318cf', N'admin@quizacademy.com', 0, N'AK9NtTp2fxNqq8nLgHZntWzmzsQpcRqYigio2uMSAfMSjDnLxXooW79/hueeQBNL+g==', N'2b2bb864-6cb5-4a91-b59a-e60017000d6a', NULL, 0, 0, NULL, 1, 0, N'admin@quizacademy.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'678c911e-4ddd-4c27-892b-537b34763ecf', N'CanManageQuestions')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'573de45c-d173-48a0-9a15-938e9d7318cf', N'678c911e-4ddd-4c27-892b-537b34763ecf')

");
        }
        
        public override void Down()
        {
        }
    }
}
