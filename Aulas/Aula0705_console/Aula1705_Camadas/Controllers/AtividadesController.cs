using Aula1705_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Controllers
{
    class AtividadesController
    {
        //simulando tabela
        public static List<Atividade> ListaAtividades { get; set; } = new List<Atividade>();

      /*  static AtividadesController()
        {
            ListaAtividades = new List<Atividade>();
        }
        */

        //Salvar
        public void Salvar(Atividade atividade)
        {
            atividade.AtividadeID = ListaAtividades.Count + 1;
            ListaAtividades.Add(atividade);
        }
        //Listar
        public List<Atividade> Listar()
        {
            return ListaAtividades;
        }
        //Ler
        public Atividade BuscarPorId(int id)
        {
            //return ListaAtividades.Where(a => a.AtividadeID == id).FirstOrDefault();
            foreach(Atividade a in ListaAtividades)
            {
                if(a.AtividadeID == id)
                {
                    return a;
                }
            }
            return null;
        }
        //Editar
        public void Editar(int id, Atividade atividadeAtualizada)
        {
            //ListaAtividades.Where(a => a.AtividadeID == id).FirstOrDefault();
            Atividade atividadeAntiga = BuscarPorId(id);
            if(atividadeAntiga != null)
            {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
            }

        }
        //Excluir
        public void Excluir(int id)
        {
            Atividade atividade = BuscarPorId(id);
            if(atividade != null)
            {
                ListaAtividades.Remove(atividade);
            }
        }

    }
}
