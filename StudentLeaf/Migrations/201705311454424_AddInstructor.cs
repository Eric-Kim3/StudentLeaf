namespace StudentLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstructor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InstructorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        BasePay = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.InstructorId);
            
            AddColumn("dbo.SessonRecords", "Instructor_InstructorId", c => c.Int());
            CreateIndex("dbo.SessonRecords", "Instructor_InstructorId");
            AddForeignKey("dbo.SessonRecords", "Instructor_InstructorId", "dbo.Instructors", "InstructorId");
            DropColumn("dbo.SessonRecords", "InstructorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SessonRecords", "InstructorId", c => c.Int(nullable: false));
            DropForeignKey("dbo.SessonRecords", "Instructor_InstructorId", "dbo.Instructors");
            DropIndex("dbo.SessonRecords", new[] { "Instructor_InstructorId" });
            DropColumn("dbo.SessonRecords", "Instructor_InstructorId");
            DropTable("dbo.Instructors");
        }
    }
}
