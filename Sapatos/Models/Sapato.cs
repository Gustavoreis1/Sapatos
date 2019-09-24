using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapatos.Models
{
    public class Sapato
    {
        [Key]
        public int ID_Sapato { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Numeração é requerido!!")]
        public int Numerecao { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Quantidade é requerido!!")]
        public int Quantidade { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O Modelo é requerido!!")]
        public Modelo Modelo { get; set; }
    }
}
