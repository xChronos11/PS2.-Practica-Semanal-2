namespace PS2._Practica_Semanal_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Precio", c => c.Single(nullable: false));
            DropColumn("dbo.Products", "Imagen");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Imagen", c => c.String());
            DropColumn("dbo.Products", "Precio");
        }
    }
}
