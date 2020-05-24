namespace PS2._Practica_Semanal_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MN1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NameStatus = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Orders", "StatusId", c => c.Int());
            CreateIndex("dbo.Orders", "StatusId");
            AddForeignKey("dbo.Orders", "StatusId", "dbo.Status", "id");
            DropColumn("dbo.Orders", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Status", c => c.String());
            DropForeignKey("dbo.Orders", "StatusId", "dbo.Status");
            DropIndex("dbo.Orders", new[] { "StatusId" });
            DropColumn("dbo.Orders", "StatusId");
            DropTable("dbo.Status");
        }
    }
}
