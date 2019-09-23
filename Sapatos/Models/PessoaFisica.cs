using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapatos.Models
{
    public class PessoaFisica : Cliente
    {
        [Key]
        public int ID_PF { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo CPF é requerido!!")]
        [MaxLength(15, ErrorMessage = "O campo CPF recebe no máximo 15 caracteres")]
        public string CPF { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Data de Nascimento é requerido!!")]
        public DateTime DataNascimento { get; set; }
    }
}
