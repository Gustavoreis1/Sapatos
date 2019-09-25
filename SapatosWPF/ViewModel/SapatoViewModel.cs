using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sapatos.Models;

namespace SapatosWPF.ViewModel
{
    public class SapatoViewModel
    {
        public ObservableCollection<Sapato> Sapatos { get; set; }
        public ObservableCollection<Modelo> Modelos { get; set; }

        public Boolean PodeExcluir
        {
            get
            {
                return this.SapatoSelecionado != null;
            }
        }
        public Sapato SapatoSelecionado { get; set; }
        public Modelo ModeloSelecionado { get; set; }
        private SapatosContext context { get; set; }
        public Sapato Sapato { get; set; }
        
        public SapatoViewModel()
        {
            Sapato = new Sapato();
            context = new SapatosContext();
            this.Sapatos = new ObservableCollection<Sapato>(context.Sapatos.Include("Modelo").ToList());
            this.Modelos = new ObservableCollection<Modelo>(context.Modelos.ToList());
            this.SapatoSelecionado = context.Sapatos.Include("Modelo").FirstOrDefault();
            this.ModeloSelecionado = context.Modelos.FirstOrDefault();
        }


        public void Salvar()
        {

            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if (this.SapatoSelecionado.ID_Sapato != 0)
            {
                this.context.Sapatos.Remove(this.SapatoSelecionado);
                this.Sapatos.Remove(this.SapatoSelecionado);
            }
        }
        public void Adicionar()
        {
            Sapato NewSapato = new Sapato();
            this.Sapatos.Add(NewSapato);
            this.context.Sapatos.Add(NewSapato);
            this.SapatoSelecionado = NewSapato;
        }
    }
}
