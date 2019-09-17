using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatosWPF.ViewModel
{
    class PessoaFisicaViewModel
    {

        public Sapatos.Models.Endereco Endereco { get; set; }
        public Sapatos.Models.Cidades Cidade { get; set; }
        public Sapatos.Models.PessoaFisica pfSelecionada { get; set; }
        public ObservableCollection<Sapatos.Models.PessoaFisica> pessoas { get; set; }
        Sapatos.Models.SapatosContext context { get; set; }

        public Boolean podeExcluir => this.pfSelecionada != null;
        public PessoaFisicaViewModel()
        {
            context = new Sapatos.Models.SapatosContext();
            this.pessoas = new ObservableCollection<Sapatos.Models.PessoaFisica>(context.PessoaFisicas.ToList());
            this.pfSelecionada = context.PessoaFisicas.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if(this.pfSelecionada.ID_Cliente != 0)
            {
                this.context.PessoaFisicas.Remove(this.pfSelecionada);

            }
        }


    }
}
