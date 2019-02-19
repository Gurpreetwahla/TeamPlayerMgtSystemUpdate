namespace TeamPlayerMgtSystemUpdate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesNew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        CoachId = c.Int(nullable: false, identity: true),
                        CoachName = c.String(),
                    })
                .PrimaryKey(t => t.CoachId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        CoachName = c.String(),
                        Name = c.String(),
                        Position = c.String(),
                        Mobile = c.String(),
                        Gender = c.String(),
                        CoachId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Coaches", t => t.CoachId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.CoachId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        City = c.String(),
                        Province = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Players", "CoachId", "dbo.Coaches");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Players", new[] { "CoachId" });
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
            DropTable("dbo.Coaches");
        }
    }
}
