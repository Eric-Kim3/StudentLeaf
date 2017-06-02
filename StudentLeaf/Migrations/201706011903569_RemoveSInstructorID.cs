namespace StudentLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSInstructorID : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SessonRecords", "SInstructorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SessonRecords", "SInstructorId", c => c.Int(nullable: false));
        }
    }
}
