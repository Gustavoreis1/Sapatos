using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapatos.Models
{
    public class Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }
        public Endereco Endereco { get; set; }
        public String Nome { get; set; }
    }
}
