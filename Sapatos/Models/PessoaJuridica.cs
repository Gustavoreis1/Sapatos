using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapatos.Models
{
    public class PessoaJuridica : Cliente
    {
        [Key]
        public int ID_PJ { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Razão Social é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Razão Social recebe no máximo 100 caracteres")]
        public string RazaoSocial { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo CNPJ é requerido!!")]
        [MaxLength(18, ErrorMessage = "O campo CNPJ recebe no máximo 18 caracteres")]
        public string CNPJ { get; set; }
    }
}
