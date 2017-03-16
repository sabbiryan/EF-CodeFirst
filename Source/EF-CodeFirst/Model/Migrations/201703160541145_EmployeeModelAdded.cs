namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CompanyId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Designation = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            DropTable("dbo.Employees");
        }
    }
}
