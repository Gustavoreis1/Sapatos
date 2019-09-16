using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sapatos.Models
{
    public class SapatosContext : DbContext
    {
        public SapatosContext() : base("SapatosBD")
        {

        }
        //DESABILITAR CASCATAS

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public virtual DbSet<Sapatos.Models.Estados> Estados { get; set; }

        public virtual DbSet<Sapatos.Models.Cidades> Cidades { get; set; }

        public virtual DbSet<Sapatos.Models.Cliente> Clientes { get; set; }

        public virtual DbSet<Sapatos.Models.Modelo> Modelos { get; set; }

        public virtual DbSet<Sapatos.Models.Venda> Vendas  { get; set; }

    }
}
