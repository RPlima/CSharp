using Aula1705_Camadas.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Atividade> Atividades { get; set; }

        public DbSet<Categorias> Categorias { get; set; }
    }
}
