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

        #region Salvar Atividade
        public void Salvar(Atividade atividade)
        {
            atividade.AtividadeID = ListaAtividades.Count + 1;
            ListaAtividades.Add(atividade);
        }
        #endregion

        #region Listar Todos
        public List<Atividade> Listar()
        {
            return ListaAtividades;
        }
        #endregion

        #region Listar Ativos e Inativos
        public List<Atividade> ListarAtivos_Inativos(bool ativo)
         {
            IEnumerable<Atividade> atividadesSelecionadas = new List<Atividade>();
            atividadesSelecionadas = from x in ListaAtividades
                                     where x.Ativo == ativo
                                     select x;

            return atividadesSelecionadas.ToList();
        }
        #endregion

        #region Método BuscarPorId
        public Atividade BuscarPorId(int id)
        {
           // return ListaAtividades.Where(a => a.AtividadeID == id).FirstOrDefault();
            foreach(Atividade a in ListaAtividades)
            {
                if(a.AtividadeID == id)
                {
                    return a;
                }
            }
            return null;
        }

        #endregion

        #region Método buscar pelo nome
        public List<Atividade> BuscarByNome(string nome)
        {
            IEnumerable<Atividade> atividadesSelecionadas = new List<Atividade>();

            atividadesSelecionadas = from x in ListaAtividades
                                     where x.Nome.ToLower().Contains(nome.ToLower())
                                     select x;
         /*   foreach (Atividade a in ListaAtividades)
            {
                if(a.Nome.ToLower().Contains(nome.ToLower()))
                {
                    atividadesSelecionadas.Add(a);
                }
            }*/


            return atividadesSelecionadas.ToList();
        }
        #endregion

        #region Editar Atividade
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
        #endregion

        #region Excluir Atividade
        public void Excluir(int id)
        {
            Atividade atividade = BuscarPorId(id);
            if(atividade != null)
            {
                ListaAtividades.Remove(atividade);
            }
        }
        #endregion

    }
}
