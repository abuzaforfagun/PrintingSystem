namespace PrintingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrintingInputsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrintingInputs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrinterQuantity = c.Int(nullable: false),
                        PhotocopyQuantity = c.Int(nullable: false),
                        Purpose = c.String(),
                        Date = c.DateTime(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrintingInputs", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.PrintingInputs", new[] { "User_Id" });
            DropTable("dbo.PrintingInputs");
        }
    }
}
