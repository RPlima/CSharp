using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Model
{
    public class Atividade
    {
        [Key]
        public int AtividadeID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }
       [Required, StringLength(250)]
        public string Descricao { get; set; }


        public int CategoriaID{get; set;}

        public bool Ativo { get; set; }
    }
}
