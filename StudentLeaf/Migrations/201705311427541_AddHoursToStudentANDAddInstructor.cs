namespace StudentLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHoursToStudentANDAddInstructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SessonRecords", "Hours", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SessonRecords", "Hours");
        }
    }
}
