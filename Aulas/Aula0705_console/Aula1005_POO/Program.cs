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
            Console.WriteLine("cl2.Nome:"+cli2.Nome);


            //Cliente cli3 = new Cliente("Juciliuda","123");
            cli2.DataNasc = new DateTime(1996,05,09);
            Console.WriteLine(cli2.Nome+"Nasceu em: "+cli2.DataNasc);
            Console.WriteLine("Dados:"+ ImprimirInfo());

            Console.ReadKey();
        }
    }
}
