using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatosWPF.ViewModel
{
    
    public class ModeloViewModel
    {
        public Sapatos.Models.Modelo Modelo { get; set; }
        public ObservableCollection<Sapatos.Models.Modelo> Modelos { get; set; }
        Sapatos.Models.SapatosContext context { get; set; }
        public Sapatos.Models.Modelo ModeloSelecionado { get; set; }

        public ModeloViewModel()
        {
            this.Modelo = new Sapatos.Models.Modelo();
            context = new Sapatos.Models.SapatosContext();
            this.Modelos = new ObservableCollection<Sapatos.Models.Modelo>(context.Modelos.ToList());
            this.ModeloSelecionado = context.Modelos.FirstOrDefault();
        }

        public void Salvar()
        {

            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if (this.ModeloSelecionado.ID_Nodelo != 0)
            {

                this.context.Modelos.Remove(this.ModeloSelecionado);

                this.Modelos.Remove(this.ModeloSelecionado);
            }
        }
        public void Adicionar()
        {
            Sapatos.Models.Modelo NewModelo = new Sapatos.Models.Modelo();
            this.Modelos.Add(NewModelo);
            this.context.Modelos.Add(NewModelo);
            this.ModeloSelecionado = NewModelo;
        }
    }
}
