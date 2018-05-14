using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
     public abstract class Pessoa
    {
        private string nome;
        private string cpf;

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Pessoa() { }
        public Pessoa(string Nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public  abstract  string ImprimirInfo();
    }
}
