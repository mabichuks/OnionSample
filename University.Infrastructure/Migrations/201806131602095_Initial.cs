namespace University.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.Students", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Students", "Faculty_Id", "dbo.Faculties");
            DropIndex("dbo.Departments", new[] { "Faculty_Id" });
            DropIndex("dbo.Students", new[] { "Department_Id" });
            DropIndex("dbo.Students", new[] { "Faculty_Id" });
            RenameColumn(table: "dbo.Departments", name: "Faculty_Id", newName: "FacultyId");
            RenameColumn(table: "dbo.Students", name: "Department_Id", newName: "DepartmentId");
            RenameColumn(table: "dbo.Students", name: "Faculty_Id", newName: "FacultyId");
            AlterColumn("dbo.Departments", "FacultyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "DepartmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "FacultyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "FacultyId");
            CreateIndex("dbo.Students", "FacultyId");
            CreateIndex("dbo.Students", "DepartmentId");
            AddForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "FacultyId" });
            DropIndex("dbo.Departments", new[] { "FacultyId" });
            AlterColumn("dbo.Students", "FacultyId", c => c.Int());
            AlterColumn("dbo.Students", "DepartmentId", c => c.Int());
            AlterColumn("dbo.Departments", "FacultyId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "FacultyId", newName: "Faculty_Id");
            RenameColumn(table: "dbo.Students", name: "DepartmentId", newName: "Department_Id");
            RenameColumn(table: "dbo.Departments", name: "FacultyId", newName: "Faculty_Id");
            CreateIndex("dbo.Students", "Faculty_Id");
            CreateIndex("dbo.Students", "Department_Id");
            CreateIndex("dbo.Departments", "Faculty_Id");
            AddForeignKey("dbo.Students", "Faculty_Id", "dbo.Faculties", "Id");
            AddForeignKey("dbo.Students", "Department_Id", "dbo.Departments", "Id");
            AddForeignKey("dbo.Departments", "Faculty_Id", "dbo.Faculties", "Id");
        }
    }
}
