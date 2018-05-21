using Aula1705_Camadas.Controllers;
using Aula1705_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Views
{
    class AtividadeView
    {
        private AtividadesController atividadeController;

         enum OpcoesMenu
        {
            CriarAtividade = 1,
            ListarAtividade = 2,
            BuscarAtividade = 3,
            EditarAtividade = 4,
            ExcluirAtividade =5,
            BuscarAtividadeNome = 6,
            ListarAtividadesAtivo_Inativo = 7,
            Sair = 9
        }

        public AtividadeView()
        {
            atividadeController = new AtividadesController();
        }


        public void ExibirMenu()
        {
            OpcoesMenu op = OpcoesMenu.Sair;
            do
            {
                Console.WriteLine("=====================");
                Console.WriteLine(" Escolha uma opcao!   ");
                Console.WriteLine(" 1) Criar Atividade   ");
                Console.WriteLine(" 2) Listar Atividades ");
                Console.WriteLine(" 3) Buscar Atividade  ");
                Console.WriteLine(" 4) Editar Atividade  ");
                Console.WriteLine(" 5) Excluir Atividade ");
                Console.WriteLine(" 6) Buscar Por nome");
                Console.WriteLine(" 7) Listar Atividades (Ativos/Inativos)");
                Console.WriteLine(" 9) Sair ");
                Console.WriteLine("=====================");
                 op = (OpcoesMenu)int.Parse(Console.ReadLine());

                switch (op)
                {
                    case OpcoesMenu.CriarAtividade:
                        CriarAtividade();

                        break;
                    case OpcoesMenu.ListarAtividade:
                        ListarAtividades();

                        break;
                    case OpcoesMenu.BuscarAtividade:
                        BuscarAtividade();

                        break;
                    case OpcoesMenu.EditarAtividade:
                        EditarAtividade();

                        break;
                    case OpcoesMenu.ExcluirAtividade:
                        ExcluirAtividade();

                        break;
                    case OpcoesMenu.BuscarAtividadeNome:
                        BuscarAtividadeByNome();
                        break;
                    case OpcoesMenu.ListarAtividadesAtivo_Inativo:
                       // ListarAtivos_Inativos();

                        break;
                    case OpcoesMenu.Sair:

                        break;
                    default:
                        break;
                } 

              } while (op != OpcoesMenu.Sair);
        }

        private void BuscarAtividadeByNome()
        {
            Console.Write("Digite o nome da atividade que deseja procurar:");
            string nomeAtividade = Console.ReadLine();
            Console.WriteLine("-- Exibindo a lista de atividades por nome --");
            foreach(Atividade a in atividadeController.BuscarByNome(nomeAtividade))
            {
                ExibirDetalhesAtividade(a);
            }
            Console.WriteLine("-- Fim da lista de atividades por nome --");
            Console.ReadKey();
        }

        private void ExcluirAtividade()
        {
            ListarAtividades();
            Console.WriteLine("Digite o id da atividade que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());
            Atividade atividadeAtualizada = ObterDadosAtividade();

            atividadeController.Excluir(id);
        }

        private void EditarAtividade()
        {
            ListarAtividades();
            Console.WriteLine("Digite o id da atividade que deseja editar: ");
           int id = int.Parse(Console.ReadLine());
            Atividade atividadeAtualizada = ObterDadosAtividade();
            
            atividadeController.Editar(id, atividadeAtualizada);
        }

        private void CriarAtividade()
        {
            Atividade atividade = ObterDadosAtividade();

           
            atividadeController.Salvar(atividade);
        }

        private static Atividade ObterDadosAtividade()
        {
            Atividade atividade = new Atividade();
            Console.WriteLine("Digite o nome de atividade:");
            atividade.Nome = Console.ReadLine();

            Console.WriteLine("Ativo? (s/n):");
            atividade.Ativo = Console.ReadLine() == "s" ? true : false;

            return atividade;
        }

        private void BuscarAtividade()
        {
         
            Console.WriteLine("Digite o id da atividade: ");
            int id = int.Parse(Console.ReadLine());
            Atividade atividade = atividadeController.BuscarPorId(id);
            if(atividade != null)
            {
                ExibirDetalhesAtividade(atividade);
            }
            else
            {
                Console.WriteLine("Atividade não existente!");
            }
        }

        private void ListarAtividades()
        {
            
            foreach (Atividade atividade in atividadeController.Listar())
            {
                ExibirDetalhesAtividade(atividade);
            }
            Console.WriteLine("Fim da List");
            Console.ReadKey();
        }

       /* private void ListarAtivos_Inativos()
        {
            Console.WriteLine("Deseja listar Ativos Ou Inativos?(Ativo = s/Inativo = n)");
            bool ativo = Console.ReadLine() == "s" ? true : false;
            try
            {
                foreach (Atividade atividade in atividadeController.ListarAtivos_Inativos(ativo))
                {
                    ExibirDetalhesAtividade(atividade);
                }
                Console.WriteLine("Fim da List");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            } 
        }*/

        private static void ExibirDetalhesAtividade(Atividade atividade)
        {
            Console.WriteLine("---");
            Console.WriteLine("Id: " + atividade.AtividadeID);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
        }
    }
}
