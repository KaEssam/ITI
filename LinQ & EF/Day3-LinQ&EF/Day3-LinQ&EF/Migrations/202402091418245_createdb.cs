namespace Day3_LinQ_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        SchoolID = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        SchoolType = c.String(),
                        Department_DepartmentID = c.Int(),
                    })
                .PrimaryKey(t => t.SchoolID)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentID)
                .Index(t => t.Department_DepartmentID);
            
            CreateTable(
                "dbo.TeacherTransferes",
                c => new
                    {
                        TeacherTransfereID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TeacherID = c.Int(nullable: false),
                        FromSchoolID = c.Int(),
                        ToSchoolID = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherTransfereID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.FromSchoolID)
                .ForeignKey("dbo.Schools", t => t.ToSchoolID)
                .Index(t => t.TeacherID)
                .Index(t => t.FromSchoolID)
                .Index(t => t.ToSchoolID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        Qualification = c.String(),
                        QualificationDate = c.DateTime(nullable: false),
                        HiringDate = c.DateTime(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        Job = c.String(),
                        Code = c.Int(nullable: false),
                        NationalID = c.Int(nullable: false),
                        Notes = c.String(),
                        Phone = c.String(),
                        School_SchoolID = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherID)
                .ForeignKey("dbo.Schools", t => t.School_SchoolID)
                .Index(t => t.School_SchoolID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherTransferes", "ToSchoolID", "dbo.Schools");
            DropForeignKey("dbo.TeacherTransferes", "FromSchoolID", "dbo.Schools");
            DropForeignKey("dbo.TeacherTransferes", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "School_SchoolID", "dbo.Schools");
            DropForeignKey("dbo.Schools", "Department_DepartmentID", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "School_SchoolID" });
            DropIndex("dbo.TeacherTransferes", new[] { "ToSchoolID" });
            DropIndex("dbo.TeacherTransferes", new[] { "FromSchoolID" });
            DropIndex("dbo.TeacherTransferes", new[] { "TeacherID" });
            DropIndex("dbo.Schools", new[] { "Department_DepartmentID" });
            DropTable("dbo.Teachers");
            DropTable("dbo.TeacherTransferes");
            DropTable("dbo.Schools");
            DropTable("dbo.Departments");
        }
    }
}
