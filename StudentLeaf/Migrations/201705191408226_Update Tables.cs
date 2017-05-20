namespace StudentLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ActiveLessons", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.SessonRecords", "Student_Id", "dbo.Students");
            DropIndex("dbo.ActiveLessons", new[] { "Student_Id" });
            DropIndex("dbo.SessonRecords", new[] { "Student_Id" });
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.ActiveLessons", "Student_Id", c => c.Int());
            AlterColumn("dbo.SessonRecords", "InstructorId", c => c.Int(nullable: false));
            AlterColumn("dbo.SessonRecords", "SInstructorId", c => c.Int(nullable: false));
            AlterColumn("dbo.SessonRecords", "Student_Id", c => c.Int());
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Students", "Id");
            CreateIndex("dbo.ActiveLessons", "Student_Id");
            CreateIndex("dbo.SessonRecords", "Student_Id");
            AddForeignKey("dbo.ActiveLessons", "Student_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.SessonRecords", "Student_Id", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessonRecords", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.ActiveLessons", "Student_Id", "dbo.Students");
            DropIndex("dbo.SessonRecords", new[] { "Student_Id" });
            DropIndex("dbo.ActiveLessons", new[] { "Student_Id" });
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.SessonRecords", "Student_Id", c => c.Guid());
            AlterColumn("dbo.SessonRecords", "SInstructorId", c => c.Guid(nullable: false));
            AlterColumn("dbo.SessonRecords", "InstructorId", c => c.Guid(nullable: false));
            AlterColumn("dbo.ActiveLessons", "Student_Id", c => c.Guid());
            AddPrimaryKey("dbo.Students", "Id");
            CreateIndex("dbo.SessonRecords", "Student_Id");
            CreateIndex("dbo.ActiveLessons", "Student_Id");
            AddForeignKey("dbo.SessonRecords", "Student_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.ActiveLessons", "Student_Id", "dbo.Students", "Id");
        }
    }
}
