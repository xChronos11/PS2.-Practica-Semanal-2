namespace PS2._Practica_Semanal_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Precio", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Precio", c => c.Single(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
