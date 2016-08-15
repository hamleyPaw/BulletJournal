namespace HamleyPaw.BulletJournal.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskInstants",
                c => new
                    {
                        TaskInstantId = c.Int(nullable: false, identity: true),
                        TopicTaskId = c.Int(nullable: false),
                        InstantTicks = c.Long(nullable: false),
                        Type = c.Int(nullable: false),
                        Text = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.TaskInstantId)
                .ForeignKey("dbo.TopicTasks", t => t.TopicTaskId, cascadeDelete: true)
                .Index(t => t.TopicTaskId);
            
            CreateTable(
                "dbo.TopicTasks",
                c => new
                    {
                        TopicTaskId = c.Int(nullable: false, identity: true),
                        TopicId = c.Int(nullable: false),
                        Title = c.String(maxLength: 50),
                        TaskStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TopicTaskId)
                .ForeignKey("dbo.Topics", t => t.TopicId, cascadeDelete: true)
                .Index(t => t.TopicId);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        TopicId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Description = c.String(maxLength: 150),
                        Notes = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TopicId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskInstants", "TopicTaskId", "dbo.TopicTasks");
            DropForeignKey("dbo.TopicTasks", "TopicId", "dbo.Topics");
            DropIndex("dbo.TopicTasks", new[] { "TopicId" });
            DropIndex("dbo.TaskInstants", new[] { "TopicTaskId" });
            DropTable("dbo.Topics");
            DropTable("dbo.TopicTasks");
            DropTable("dbo.TaskInstants");
        }
    }
}
