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
        private SapatosContext context { get; set; }

        public ObservableCollection<Venda> Vendas { get; set; }
        public Venda VendaSelecionada { get; set; }


        public Boolean podeExcluir => this.VendaSelecionada != null;
        public VendaViewModel()
        {
            this.Venda = new Venda();
            context = new SapatosContext();
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
