using Aula1705_Camadas.Controllers;
using Aula1705_Camadas.DAL;
using Aula1705_Camadas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Controllers
{
   public class AtividadesController : IBaseController<Atividade>
    {
        //simulando tabela
        private Contexto contexto = new Contexto();
        public void Adicionar(Atividade Entity)
        {
            contexto.Atividades.Add(Entity);
            contexto.SaveChanges();
        }

        public IList<Atividade> ListarTodos()
        {
            return contexto.Atividades.ToList();
        }

        public IList<Atividade> ListarPorNome(string nome)
        {
            /* var atividadesComNome = from a in contexto.Atividades
                         where a.Nome == nome
                         select a;
             return atividadesComNome.ToList();
             */
            return contexto.Atividades.Where(a => a.Nome == nome).ToList();
        }

        public Atividade BuscarPorID(int id)
        {
            return contexto.Atividades.Find(id);
        }

        public void Atualizar(Atividade objeto)
        {
            contexto.Entry(objeto).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Atividade a = BuscarPorID(id);
            if (a != null)
            {
                // FORMA 1
                  contexto.Atividades.Remove(a);
                //FORMA 2
                //context.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();

            }
        }
        #region CRUD ANTIGO
        /*  static AtividadesController()
          {
              ListaAtividades = new List<Atividade>();
          }
          */
        /*
      #region Salvar Atividade
      public void Salvar(Atividade atividade)
      {
          atividade.AtividadeID = ultimoIdUtilizado++;
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
          }


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
      */
        #endregion

    }
}
