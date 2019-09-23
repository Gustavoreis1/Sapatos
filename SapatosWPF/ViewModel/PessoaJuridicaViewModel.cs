using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatosWPF.ViewModel
{
    public class PessoaJuridicaViewModel
    {
        public Sapatos.Models.PessoaJuridica PessoaJuridica { get; set; }
        public Sapatos.Models.Endereco Endereco { get; set; }
        public Sapatos.Models.Cidades Cidade { get; set; }
        public Sapatos.Models.PessoaJuridica pjSelecionada { get; set; }
        public ObservableCollection<Sapatos.Models.PessoaJuridica> Pessoas { get; set; }
        Sapatos.Models.SapatosContext context { get; set; }

        public Boolean podeExcluir => this.pjSelecionada != null;
        public PessoaJuridicaViewModel()
        {
            this.PessoaJuridica = new Sapatos.Models.PessoaJuridica();
            context = new Sapatos.Models.SapatosContext();
            this.Pessoas = new ObservableCollection<Sapatos.Models.PessoaJuridica>(context.PessoaJuridicas.Include("Endereco").ToList());
            this.pjSelecionada = context.PessoaJuridicas.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Excluir()
        {
            if (this.pjSelecionada.ID_Cliente != 0)
            {
                this.context.PessoaJuridicas.Remove(this.pjSelecionada);

            }
        }

    }
}
