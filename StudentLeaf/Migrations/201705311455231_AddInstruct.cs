namespace StudentLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstruct : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SessonRecords", "Instructor_InstructorId", "dbo.Instructors");
            DropIndex("dbo.SessonRecords", new[] { "Instructor_InstructorId" });
            RenameColumn(table: "dbo.SessonRecords", name: "Instructor_InstructorId", newName: "InstructorId");
            AlterColumn("dbo.SessonRecords", "InstructorId", c => c.Int(nullable: false));
            CreateIndex("dbo.SessonRecords", "InstructorId");
            AddForeignKey("dbo.SessonRecords", "InstructorId", "dbo.Instructors", "InstructorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessonRecords", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.SessonRecords", new[] { "InstructorId" });
            AlterColumn("dbo.SessonRecords", "InstructorId", c => c.Int());
            RenameColumn(table: "dbo.SessonRecords", name: "InstructorId", newName: "Instructor_InstructorId");
            CreateIndex("dbo.SessonRecords", "Instructor_InstructorId");
            AddForeignKey("dbo.SessonRecords", "Instructor_InstructorId", "dbo.Instructors", "InstructorId");
        }
    }
}
