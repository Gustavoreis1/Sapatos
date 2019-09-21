using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatosWPF.ViewModel
{
    public class EstadosViewModel
    {
        public Sapatos.Models.Estados Estado { get; set; }

        Sapatos.Models.SapatosContext context { get; set; }

        public Sapatos.Models.Estados estadoSelecionado { get; set; }
        public ObservableCollection<Sapatos.Models.Estados> Estados { get; set; }

        public Boolean podeExcluir => this.estadoSelecionado != null;
        public EstadosViewModel()
        {
            context = new Sapatos.Models.SapatosContext();
            this.Estado = new Sapatos.Models.Estados();
            this.Estados = new ObservableCollection<Sapatos.Models.Estados>(context.Estados.ToList());
            this.estadoSelecionado = context.Estados.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if (this.estadoSelecionado.ID_Estado != 0)
            {
                this.context.Estados.Remove(this.estadoSelecionado);

            }
        }

        public void Adicionar()
        {
            Sapatos.Models.Estados e = new Sapatos.Models.Estados();
            this.Estados.Add(e);
            this.context.Estados.Add(e);
            this.estadoSelecionado = e;
        }

    }
}