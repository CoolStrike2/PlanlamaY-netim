namespace PlanlamaYönetim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventDate = c.DateTime(nullable: false),
                        EventBeginTime = c.DateTime(nullable: false),
                        EventIdentify = c.DateTime(nullable: false),
                        EventDescription = c.String(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SureName = c.String(),
                        NickName = c.String(),
                        Password = c.String(),
                        TCNo = c.String(),
                        UserTel = c.String(),
                        UserEmail = c.String(),
                        UserAddress = c.String(),
                        UserType = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "User_UserID", "dbo.Users");
            DropIndex("dbo.Events", new[] { "User_UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Events");
        }
    }
}
