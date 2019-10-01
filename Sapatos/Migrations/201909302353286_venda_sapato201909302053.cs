namespace Sapatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class venda_sapato201909302053 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendas", "Quantidade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendas", "Quantidade", c => c.String(nullable: false));
        }
    }
}
