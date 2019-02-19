namespace TeamPlayerMgtSystemUpdate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCoachName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Players", "CoachName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "CoachName", c => c.String());
        }
    }
}
