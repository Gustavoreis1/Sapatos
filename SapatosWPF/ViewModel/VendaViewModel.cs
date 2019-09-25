using Sapatos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatosWPF.ViewModel
{
    public class VendaViewModel
    {
        public Venda Venda { get; set; }
        public Modelo Modelo { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        private SapatosContext context { get; set; }

        public ObservableCollection<Venda> Vendas { get; set; }
        public ObservableCollection<Modelo> Modelos { get; set; }
        public ObservableCollection<PessoaFisica> PessoaFisicas { get; set; }
        public ObservableCollection<PessoaJuridica> PessoaJuridicas { get; set; }
        public Venda VendaSelecionada { get; set; }
        public Modelo ModeloSelecionado { get; set; }


        public Boolean podeExcluir => this.VendaSelecionada != null;
        public VendaViewModel()
        {
            this.Venda = new Venda();
            context = new SapatosContext();
            this.Modelos = new ObservableCollection<Modelo>(context.Modelos.ToList());
            this.ModeloSelecionado = context.Modelos.FirstOrDefault();
        }
        public void Salvar()
        {

            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if (this.VendaSelecionada.ID_Venda != 0)
            {
                this.context.Vendas.Remove(this.VendaSelecionada);

            }
        }
        public void Adicionar()
        {
            Venda NewVenda = new Venda();
            this.Vendas.Add(NewVenda);
            this.context.Vendas.Add(NewVenda);
            this.VendaSelecionada = NewVenda;
        }


    }
}
