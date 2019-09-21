using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatosWPF.ViewModel
{
    public class CidadesViewModel
    {
        public Sapatos.Models.Cidades Cidade { get; set; }

        public Sapatos.Models.Estados Estado { get; set; }

        Sapatos.Models.SapatosContext context { get; set; }

        public Sapatos.Models.Cidades cidadeSelecionada { get; set; }
        public ObservableCollection<Sapatos.Models.Cidades> cidades { get; set; }

        public Sapatos.Models.Estados estadosSelecionada { get; set; }
        public ObservableCollection<Sapatos.Models.Estados> Estados { get; set; }


        public Boolean podeExcluir => this.cidadeSelecionada != null;
        public CidadesViewModel()
        {
            context = new Sapatos.Models.SapatosContext();
            this.Estado = new Sapatos.Models.Estados();
            this.cidades = new ObservableCollection<Sapatos.Models.Cidades>(context.Cidades.ToList());
            this.cidadeSelecionada = context.Cidades.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if (this.cidadeSelecionada.ID_Cidade != 0)
            {
                this.context.Cidades.Remove(this.cidadeSelecionada);

            }
        }

        public void Adicionar()
        {
            Sapatos.Models.Cidades c = new Sapatos.Models.Cidades();
            this.cidades.Add(c);
            this.context.Cidades.Add(c);
            this.cidadeSelecionada = c;
        }

    }
}
