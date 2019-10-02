using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sapatos.Models;

namespace SapatosWPF.ViewModel
{
    public class PessoaJuridicaViewModel
    {
        public PessoaJuridica PessoaJuridica { get; set; }
        public Endereco Endereco { get; set; }
        public Cidades Cidade { get; set; }
        public Estados Estado { get; set; }
        public PessoaJuridica PjSelecionada { get; set; }
        public ObservableCollection<PessoaJuridica> Pessoas { get; set; }
        public ObservableCollection<Cidades> Cidades { get; set; }
        public ObservableCollection<Estados> Estados { get; set; }
        private SapatosContext context { get; set; }
        public Cidades CidadeSelecionada { get; set; }
        public Estados EstadoSelecionado { get; set; }

        public Boolean PodeExcluir => this.PjSelecionada != null;
        public PessoaJuridicaViewModel()
        {
            this.PessoaJuridica = new PessoaJuridica();
            this.Endereco = new Endereco();
            this.Cidade = new Cidades();
            this.Estado = new Estados();
            context = new SapatosContext();
            this.Pessoas = new ObservableCollection<PessoaJuridica>(context.PessoaJuridicas.Include("Endereco").ToList());
            this.PjSelecionada = context.PessoaJuridicas.Include("Endereco").FirstOrDefault();
            this.Cidades = new ObservableCollection<Cidades>(context.Cidades.Include("Estado").ToList());
            this.Estados = new ObservableCollection<Estados>(context.Estados.ToList());
            this.CidadeSelecionada = context.Cidades.FirstOrDefault();
            this.EstadoSelecionado = context.Estados.FirstOrDefault();
        }

        public void Salvar()
        {
            this.Cidade.Estado = Estado;
            this.Endereco.Cidade = Cidade;
            this.PjSelecionada.Endereco = Endereco;
            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if (this.PjSelecionada.ID_Cliente != 0)
            {
                this.context.PessoaJuridicas.Remove(this.PjSelecionada);

            }
            this.Pessoas.Remove(this.PjSelecionada);
        }

        public void Adicionar()
        {
            Sapatos.Models.PessoaJuridica NewPj = new Sapatos.Models.PessoaJuridica();
            this.Pessoas.Add(NewPj);
            this.context.Clientes.Add(NewPj);
            this.PjSelecionada = NewPj;
        }

    }
}
