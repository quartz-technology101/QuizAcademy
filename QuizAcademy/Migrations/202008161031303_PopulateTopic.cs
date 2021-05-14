namespace QuizAcademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTopic : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Topics (Name) VALUES('History')");
            Sql("Insert INTO Topics (Name) VALUES('Geography')");
            Sql("Insert INTO Topics (Name) VALUES('Sports')");
            Sql("Insert INTO Topics (Name) VALUES('Information Technology')");
        }
        
        public override void Down()
        {
        }
    }
}
