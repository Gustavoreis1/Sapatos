using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapatos.Models
{
    public class Cidades
    {
        [Key]
        public int ID_Cidade { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(50, ErrorMessage = "O campo Nome recebe no máximo 50 caracteres")]
        public string Nome { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        public Estados Estados { get; set; }
    }
}
