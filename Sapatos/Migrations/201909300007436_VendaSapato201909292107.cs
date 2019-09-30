namespace Sapatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VendaSapato201909292107 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sapatoes", "Venda_ID_Venda", c => c.Int());
            CreateIndex("dbo.Sapatoes", "Venda_ID_Venda");
            AddForeignKey("dbo.Sapatoes", "Venda_ID_Venda", "dbo.Vendas", "ID_Venda");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sapatoes", "Venda_ID_Venda", "dbo.Vendas");
            DropIndex("dbo.Sapatoes", new[] { "Venda_ID_Venda" });
            DropColumn("dbo.Sapatoes", "Venda_ID_Venda");
        }
    }
}
