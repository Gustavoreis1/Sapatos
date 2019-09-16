using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapatos.Models
{
    public class Venda
    {
        [Key]
        public int ID_Venda { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Quantidade é requerido!!")]
        public string Quantidade { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Data Venda é requerido!!")]
        public DateTime DataVenda { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Valor Total é requerido!!")]
        public decimal ValorTotal { get; set; }
        public PessoaFisica PessoaFisica {get;set; }
        public PessoaJuridica PessoaJuridica { get; set; }
    }
}
