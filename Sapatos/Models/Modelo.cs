using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapatos.Models
{
    public class Modelo
    {
        [Key]
        public int ID_Nodelo { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracteres")]
        public string Nome { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Cadarço é requerido!!")]
        [MaxLength(3, ErrorMessage = "O campo Cadarço recebe no máximo 3 caracteres")]
        public string Cadarco { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Material é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Material recebe no máximo 100 caracteres")]
        public string Material { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Cor é requerido!!")]
        [MaxLength(20, ErrorMessage = "O campo Cor recebe no máximo 20 caracteres")]
        public string Cor { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "O campo Preço é requerido!!")]
        public decimal Preco { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        public string Fotografia { get; set; }
    }
}
