using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();
            cli.Nome = "Estefani";
            cli.Cpf = "123123";
            string nomeCliente = cli.Nome;
            string cpfCliente = cli.Cpf;

            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.Cpf);

            Cliente cli2 = new Cliente("Juricreia");
            Cliente cli3 = new Cliente("Juciliuda","123");

            Pessoa p = new Pessoa();

            Console.ReadKey();
        }
    }
}
