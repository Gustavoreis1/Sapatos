
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sapatos;
using Sapatos.Models;

namespace SapatosWPF.ViewModel
{
    public class EstadosViewModel
    {
        public ObservableCollection<Estados> Estados { get; set; }

        public Boolean PodeExcluir
        {
            get
            {
                return this.EstadoSelecionado != null;
            }
        }

        public Estados EstadoSelecionado { get; set; }
        private Sapatos.Models.SapatosContext context { get; set; }
        public Estados estado { get; set; }

        public EstadosViewModel()
        {
            estado = new Estados();
            context = new Sapatos.Models.SapatosContext();
            this.Estados = new ObservableCollection<Estados>(context.Estados.ToList());
            this.EstadoSelecionado = context.Estados.FirstOrDefault();


        }

        public void Excluir()
        {
            if (this.EstadoSelecionado.ID_Estado != 0)
            {
                this.context.Estados.Remove(
                    this.EstadoSelecionado);
            }
            this.Estados.Remove(this.EstadoSelecionado);
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Adicionar()
        {
            Estados e = new Estados();
            this.Estados.Add(e);
            this.context.Estados.Add(e);
            this.EstadoSelecionado = e;
        }
    }
}