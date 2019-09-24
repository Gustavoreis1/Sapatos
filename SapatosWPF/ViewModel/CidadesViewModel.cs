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
    public class CidadesViewModel
    {
        public ObservableCollection<Cidades> Cidades { get; set; }
        public ObservableCollection<Estados> Estados { get; set; }

        public Boolean PodeExcluir
        {
            get
            {
                return this.CidadeSelecionada != null;
            }
        }
        public Estados EstadoSelecionado { get; set; }
        public Cidades CidadeSelecionada { get; set; }
        private SapatosContext context { get; set; }
        public Cidades cidade { get; set; }

        public CidadesViewModel()
        {
            cidade = new Cidades();
            context = new SapatosContext();
            this.Cidades = new ObservableCollection<Cidades>(context.Cidades.Include("Estado").ToList());
            this.Estados = new ObservableCollection<Estados>(context.Estados.ToList());
            this.CidadeSelecionada = context.Cidades.FirstOrDefault();
            this.EstadoSelecionado = context.Estados.FirstOrDefault();


        }

        public void Excluir()
        {
            if (this.CidadeSelecionada.ID_Cidade != 0)
            {
                this.context.Cidades.Remove(
                    this.CidadeSelecionada);
            }
            this.Cidades.Remove(this.CidadeSelecionada);
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Adicionar()
        {
            Cidades c = new Cidades();
            this.Cidades.Add(c);
            this.context.Cidades.Add(c);
            this.CidadeSelecionada = c;
        }
    }
}