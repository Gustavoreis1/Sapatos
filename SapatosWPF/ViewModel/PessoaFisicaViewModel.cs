using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sapatos.Models;

namespace SapatosWPF.ViewModel
{
    public class PessoaFisicaViewModel
    {
        public PessoaFisica PessoaFisica { get; set; }
        public Endereco Endereco { get; set; }
        public Cidades Cidade { get; set; }
        public Estados Estado { get; set; }
        public PessoaFisica pfSelecionada { get; set; }
        public ObservableCollection<PessoaFisica> Pessoas { get; set; }
        public ObservableCollection<Cidades> Cidades { get; set; }
        public ObservableCollection<Estados> Estados { get; set; }
        private SapatosContext context { get; set; }
        public Cidades CidadeSelecionada { get; set; }
        public Estados EstadoSelecionado { get; set; }

        public Boolean podeExcluir => this.pfSelecionada != null;
        public PessoaFisicaViewModel()
        {
            this.PessoaFisica = new PessoaFisica();
            this.Endereco = new Endereco();
            this.Cidade = new Cidades();
            this.Estado = new Estados();
            context = new SapatosContext();
            this.Pessoas = new ObservableCollection<PessoaFisica>(context.PessoaFisicas.Include("Endereco").ToList());
            this.pfSelecionada = context.PessoaFisicas.Include("Endereco").FirstOrDefault();
            this.Cidades = new ObservableCollection<Cidades>(context.Cidades.Include("Estado").ToList());
            this.Estados = new ObservableCollection<Estados>(context.Estados.ToList());
            this.CidadeSelecionada = context.Cidades.FirstOrDefault();
            this.EstadoSelecionado = context.Estados.FirstOrDefault();
        }

        public void Salvar()
        {
            
            this.Cidade.Estado = Estado;
            this.Endereco.Cidade = Cidade;
            this.pfSelecionada.Endereco = Endereco;
            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if(this.pfSelecionada.ID_Cliente != 0)
            {
                this.context.PessoaFisicas.Remove(this.pfSelecionada);

            }
            this.Pessoas.Remove(this.pfSelecionada);
        }
        public void Adicionar()
        {
            PessoaFisica NewPf = new PessoaFisica();
            this.Pessoas.Add(NewPf);
            this.context.PessoaFisicas.Add(NewPf);
            this.pfSelecionada = NewPf;
        }


    }
}
