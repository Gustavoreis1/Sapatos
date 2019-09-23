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
                    Complemento = "N/A"
                }
            };

            AdicionarPessoaFisica(context, pfTeste1);
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
    }
}
