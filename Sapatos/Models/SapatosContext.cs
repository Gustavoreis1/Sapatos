namespace Sapatos.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SapatosContext : DbContext
    {
        public SapatosContext() : base("SapatosContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cidades>();

            modelBuilder.Entity<Cliente>();

            modelBuilder.Entity<Endereco>();

            modelBuilder.Entity<Estados>();
            modelBuilder.Entity<PessoaFisica>();
            modelBuilder.Entity<Modelo>();
            modelBuilder.Entity<PessoaJuridica>();
            modelBuilder.Entity<Sapato>();
            modelBuilder.Entity<Venda>();
        }

        public virtual DbSet<Cidades> Cidades { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Endereco> Enderecos { get; set; }

        public virtual DbSet<Estados> Estados { get; set; }

        public virtual DbSet<Modelo> Modelos { get; set; }

        public virtual DbSet<PessoaFisica> PessoaFisicas { get; set; }

        public virtual DbSet<PessoaJuridica> PessoaJuridicas { get; set; }

        public virtual DbSet<Sapato> Sapatos { get; set; }

        public virtual DbSet<Venda> Vendas { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}