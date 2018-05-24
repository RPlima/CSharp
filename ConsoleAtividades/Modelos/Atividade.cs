using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public int CategoriaID { get; set; }

        public int UsuarioID { get; set; }
    }
}
