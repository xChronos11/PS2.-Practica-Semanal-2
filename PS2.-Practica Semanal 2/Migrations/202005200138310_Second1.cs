namespace PS2._Practica_Semanal_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Qty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Qty", c => c.Int(nullable: false));
        }
    }
}
