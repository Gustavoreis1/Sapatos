namespace Sapatos.Migrations
{
    using Sapatos.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sapatos.Models.SapatosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Sapatos.Models.SapatosContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            Estados Est = new Estados() { Nome = "Paraná" };
            Cidades Cid = new Cidades() { Nome = "Curitiba", Estado = Est };
            Cidades Cid2 = new Cidades() { Nome = "Morretes", Estado = Est };
            AdicionarEstado(context,Est);
            AdicionarCidade(context, Cid);
            AdicionarCidade(context, Cid2);

            Modelo m1 = new Modelo() { Nome = "teste", Cadarco = "Sim", Cor = "Preto", Fotografia = "www.teste.com.br/teste.png", Material = "Couro", Preco = 20 };
            Sapato s1 = new Sapato() { Modelo = m1, Numerecao = 47, Quantidade = 10 };
            AdicionarModelo(context,m1);
            AdicionarSapato(context,s1);

            PessoaFisica pfTeste1 = new PessoaFisica()
            {
                Nome = "Teste pessoa fisica 1",
                DataNascimento = new DateTime(1980,01,01),
                CPF = "000.000.000-00",
                Endereco = new Endereco()
                {
                    Numero = "00",
                    Logradouro = "Rua Teste",
                    CEP = "00.000-000",
                    Complemento = "N/A",
                    Cidade = Cid
                }
            };

            PessoaJuridica pjTeste1 = new PessoaJuridica()
            {
                Nome = "Teste pessoa fisica 1",
                RazaoSocial = "Empresa de teste",
                CNPJ = "00000000000100",
                Endereco = new Endereco()
                {
                    Numero = "01",
                    Logradouro = "Rua Teste 1",
                    CEP = "00.000-001",
                    Complemento = "N/A",
                    Cidade = Cid2
                }
            };

            AdicionarPessoaFisica(context, pfTeste1);
            AdicionarPessoaJuridica(context, pjTeste1);
        }
        private static void AdicionarPessoaFisica(Models.SapatosContext context, PessoaFisica pf)
        {
            PessoaFisica pessoaFisica =
                    (from db in context.PessoaFisicas
                     where db.CPF == pf.CPF
                     select db).FirstOrDefault();
            if (pessoaFisica == null)
            {
                context.PessoaFisicas.Add(pf);
            }
        }

        private static void AdicionarPessoaJuridica(Models.SapatosContext context, PessoaJuridica pj)
        {
            PessoaJuridica pessoaJuridica =
                    (from db in context.PessoaJuridicas
                     where db.CNPJ == pj.CNPJ
                     select db).FirstOrDefault();
            if (pessoaJuridica == null)
            {
                context.PessoaJuridicas.Add(pj);
            }
        }

        private static void AdicionarEstado(Models.SapatosContext context, Estados est)
        {
            Estados estados =
                    (from db in context.Estados
                     where db.Nome == est.Nome
                     select db).FirstOrDefault();
            if (estados == null)
            {
                context.Estados.Add(est);
            }
        }
        private static void AdicionarCidade(Models.SapatosContext context, Cidades cid)
        {
            Cidades c =
                    (from db in context.Cidades
                     where db.Nome == cid.Nome
                     select db).FirstOrDefault();
            if (c == null)
            {
                context.Cidades.Add(cid);
            }
        }


        private static void AdicionarModelo(Models.SapatosContext context, Modelo mod)
        {
            Modelo m =
                    (from db in context.Modelos
                     where db.Nome == mod.Nome
                     select db).FirstOrDefault();
            if (m == null)
            {
                context.Modelos.Add(mod);
            }
        }

        private static void AdicionarSapato(Models.SapatosContext context, Sapato sap)
        {
            Sapato s =
                    (from db in context.Sapatos
                     where db.ID_Sapato== sap.ID_Sapato
                     select db).FirstOrDefault();
            if (s == null)
            {
                context.Sapatos.Add(sap);
            }
        }
    }
}
