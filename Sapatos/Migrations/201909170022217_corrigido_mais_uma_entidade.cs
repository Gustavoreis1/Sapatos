namespace Sapatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class corrigido_mais_uma_entidade : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vendas", "PessoaJuridica_ID_Cliente", "dbo.Clientes");
            DropIndex("dbo.Vendas", new[] { "PessoaJuridica_ID_Cliente" });
            RenameColumn(table: "dbo.Vendas", name: "PessoaFisica_ID_Cliente", newName: "Cliente_ID_Cliente");
            RenameIndex(table: "dbo.Vendas", name: "IX_PessoaFisica_ID_Cliente", newName: "IX_Cliente_ID_Cliente");
            DropColumn("dbo.Vendas", "PessoaJuridica_ID_Cliente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vendas", "PessoaJuridica_ID_Cliente", c => c.Int());
            RenameIndex(table: "dbo.Vendas", name: "IX_Cliente_ID_Cliente", newName: "IX_PessoaFisica_ID_Cliente");
            RenameColumn(table: "dbo.Vendas", name: "Cliente_ID_Cliente", newName: "PessoaFisica_ID_Cliente");
            CreateIndex("dbo.Vendas", "PessoaJuridica_ID_Cliente");
            AddForeignKey("dbo.Vendas", "PessoaJuridica_ID_Cliente", "dbo.Clientes", "ID_Cliente");
        }
    }
}
