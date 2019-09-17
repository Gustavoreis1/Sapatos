using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapatos.Models
{
    public class Endereco
    {
        [Key]
        public int ID_Endereco { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Logradouro é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo Logradouro no máximo 50 caracteres")]
        public string Logradouro { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Numero é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo Numero no máximo 50 caracteres")]
        public string Numero { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo CEP é requerido!!")]
        [MaxLength(10, ErrorMessage = "O campo CEP no máximo 10 caracteres")]
        public string CEP { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [MaxLength(200, ErrorMessage = "O campo Complemento no máximo 200 caracteres")]
        public string Complemento { get; set; }
        public Cidades Cidade { get; set; }
    }
}
