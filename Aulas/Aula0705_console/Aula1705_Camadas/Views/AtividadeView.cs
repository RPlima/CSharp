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

        enum MinhasOpcoes
        {
            CriarAtividade = 1,
            ListarAtividade = 2,
            BuscarAtividade = 3,
            EditarAtividade = 4,
            ExcluirAtividade =5
        }

        public AtividadeView()
        {
            atividadeController = new AtividadesController();
        }
        public void ExibirMenu()
        {
            int op;
            do
            {
                Console.WriteLine("=====================");
                Console.WriteLine(" Escolha uma opcao!   ");
                Console.WriteLine(" 1) Criar Atividade   ");
                Console.WriteLine(" 2) Listar Atividades ");
                Console.WriteLine(" 3) Buscar Atividade  ");
                Console.WriteLine(" 4) Editar Atividade  ");
                Console.WriteLine(" 5) Excluir Atividade ");
                Console.WriteLine(" 9) Sair ");
                Console.WriteLine("=====================");
                 op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CriarAtividade();
                        break;
                    case 2:
                        ListarAtividades();
                        break;
                    case 3:
                        BuscarAtividade();
                        break;
                    case 4:
                        EditarAtividade();
                        break;
                    case 5:
                        ExcluirAtividade();
                        break;
                    default:
                        break;
                }
            } while (op != 9);
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
            atividade.Ativo = true;
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
