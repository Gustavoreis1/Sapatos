namespace Sapatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcao_cpf_cliente201909222149 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "CNPJ");
            RenameColumn(table: "dbo.Clientes", name: "CNPJ1", newName: "CNPJ");
            AddColumn("dbo.Clientes", "CPF", c => c.String(maxLength: 15));
            AlterColumn("dbo.Clientes", "CNPJ", c => c.String(maxLength: 18));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "CNPJ", c => c.String(maxLength: 15));
            DropColumn("dbo.Clientes", "CPF");
            RenameColumn(table: "dbo.Clientes", name: "CNPJ", newName: "CNPJ1");
            AddColumn("dbo.Clientes", "CNPJ", c => c.String(maxLength: 15));
        }
    }
}
