using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatosWPF.ViewModel
{
    public class SapatoViewModel
    {
        public Sapatos.Models.Sapato Sapato { get; set; }
        public ObservableCollection<Sapatos.Models.Sapato> Sapatos { get; set; }
        Sapatos.Models.SapatosContext context { get; set; }
        public Sapatos.Models.Sapato SapatoSelecionado { get; set; }
        public SapatoViewModel()
        {
            this.Sapato = new Sapatos.Models.Sapato();
            context = new Sapatos.Models.SapatosContext();
            this.Sapatos = new ObservableCollection<Sapatos.Models.Sapato>(context.Sapatos.ToList());
            this.SapatoSelecionado = context.Sapatos.FirstOrDefault();
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

            }
        }
        public void Adicionar()
        {
            Sapatos.Models.Sapato NewSapato = new Sapatos.Models.Sapato();
            this.Sapatos.Add(NewSapato);
            this.context.Sapatos.Add(NewSapato);
            this.SapatoSelecionado = NewSapato;
        }
    }
}
