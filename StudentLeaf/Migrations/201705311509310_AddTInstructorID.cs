namespace StudentLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTInstructorID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SessonRecords", "TInstructorId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SessonRecords", "TInstructorId");
        }
    }
}
