using Aula1705_Camadas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Controllers
{
    interface IBaseController<Tipo> where Tipo : class 
    {
        void Adicionar(Tipo Entity);

        IList<Tipo> ListarTodos();
        IList<Tipo> ListarPorNome(string nome);
        Tipo BuscarPorID(int id);
        void Atualizar(Tipo objeto);
        void Excluir(int id);
    }
}
