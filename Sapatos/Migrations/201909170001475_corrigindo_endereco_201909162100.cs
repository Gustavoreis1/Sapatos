namespace Sapatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class corrigindo_endereco_201909162100 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        ID_Cidade = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Estado_ID_Estado = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Cidade)
                .ForeignKey("dbo.Estados", t => t.Estado_ID_Estado)
                .Index(t => t.Estado_ID_Estado);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        ID_Estado = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_Estado);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID_Cliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        ID_PF = c.Int(),
                        CNPJ = c.String(maxLength: 15),
                        DataNascimento = c.DateTime(),
                        ID_PJ = c.Int(),
                        RazaoSocial = c.String(maxLength: 100),
                        CNPJ1 = c.String(maxLength: 18),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Endereco_ID_Endereco = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Cliente)
                .ForeignKey("dbo.Enderecoes", t => t.Endereco_ID_Endereco)
                .Index(t => t.Endereco_ID_Endereco);
            
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        ID_Endereco = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(nullable: false, maxLength: 50),
                        Numero = c.String(nullable: false, maxLength: 50),
                        CEP = c.String(nullable: false, maxLength: 10),
                        Complemento = c.String(maxLength: 200),
                        Cidade_ID_Cidade = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Endereco)
                .ForeignKey("dbo.Cidades", t => t.Cidade_ID_Cidade)
                .Index(t => t.Cidade_ID_Cidade);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        ID_Nodelo = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Cadarco = c.String(nullable: false, maxLength: 3),
                        Material = c.String(nullable: false, maxLength: 100),
                        Cor = c.String(nullable: false, maxLength: 20),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fotografia = c.String(),
                    })
                .PrimaryKey(t => t.ID_Nodelo);
            
            CreateTable(
                "dbo.Sapatoes",
                c => new
                    {
                        ID_Sapato = c.Int(nullable: false, identity: true),
                        Numerecao = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Sapato);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        ID_Venda = c.Int(nullable: false, identity: true),
                        Quantidade = c.String(nullable: false),
                        DataVenda = c.DateTime(nullable: false),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PessoaFisica_ID_Cliente = c.Int(),
                        PessoaJuridica_ID_Cliente = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Venda)
                .ForeignKey("dbo.Clientes", t => t.PessoaFisica_ID_Cliente)
                .ForeignKey("dbo.Clientes", t => t.PessoaJuridica_ID_Cliente)
                .Index(t => t.PessoaFisica_ID_Cliente)
                .Index(t => t.PessoaJuridica_ID_Cliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "PessoaJuridica_ID_Cliente", "dbo.Clientes");
            DropForeignKey("dbo.Vendas", "PessoaFisica_ID_Cliente", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "Endereco_ID_Endereco", "dbo.Enderecoes");
            DropForeignKey("dbo.Enderecoes", "Cidade_ID_Cidade", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "Estado_ID_Estado", "dbo.Estados");
            DropIndex("dbo.Vendas", new[] { "PessoaJuridica_ID_Cliente" });
            DropIndex("dbo.Vendas", new[] { "PessoaFisica_ID_Cliente" });
            DropIndex("dbo.Enderecoes", new[] { "Cidade_ID_Cidade" });
            DropIndex("dbo.Clientes", new[] { "Endereco_ID_Endereco" });
            DropIndex("dbo.Cidades", new[] { "Estado_ID_Estado" });
            DropTable("dbo.Vendas");
            DropTable("dbo.Sapatoes");
            DropTable("dbo.Modeloes");
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Estados");
            DropTable("dbo.Cidades");
        }
    }
}
