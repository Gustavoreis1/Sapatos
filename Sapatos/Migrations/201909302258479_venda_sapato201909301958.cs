namespace Sapatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class venda_sapato201909301958 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sapatoes", "Venda_ID_Venda", "dbo.Vendas");
            DropIndex("dbo.Sapatoes", new[] { "Venda_ID_Venda" });
            AddColumn("dbo.Vendas", "Sapato_ID_Sapato", c => c.Int());
            CreateIndex("dbo.Vendas", "Sapato_ID_Sapato");
            AddForeignKey("dbo.Vendas", "Sapato_ID_Sapato", "dbo.Sapatoes", "ID_Sapato");
            DropColumn("dbo.Sapatoes", "Venda_ID_Venda");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sapatoes", "Venda_ID_Venda", c => c.Int());
            DropForeignKey("dbo.Vendas", "Sapato_ID_Sapato", "dbo.Sapatoes");
            DropIndex("dbo.Vendas", new[] { "Sapato_ID_Sapato" });
            DropColumn("dbo.Vendas", "Sapato_ID_Sapato");
            CreateIndex("dbo.Sapatoes", "Venda_ID_Venda");
            AddForeignKey("dbo.Sapatoes", "Venda_ID_Venda", "dbo.Vendas", "ID_Venda");
        }
    }
}
