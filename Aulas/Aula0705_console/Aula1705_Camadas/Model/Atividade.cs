using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Model
{
    public class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int CategoriaID{get; set;}

        public bool Ativo { get; set; }
    }
}
