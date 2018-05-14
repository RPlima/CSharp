using System;

namespace Aula1005_POO
{
    class Cliente : Pessoa
    {
        public DateTime DataNasc { get; set; }
        public int idade {
            get
            {

                return DateTime.Now.Year - DataQueNasceu.Year;
            }

        }
  
        public Cliente()
        {

        }
        public Cliente(string nome) : base(nome)
        {

        }

        public Cliente(string nome, string cpf) : base(nome,cpf)
        {
                
        }

        public DateTime DataQueNasceu
        {
            get
            {

                return DataQueNasceu;
            }
        }

        override
        public string ImprimirInfo() {
            return Nome + ", " + Cpf + ", " + DataNasc.ToShortDateString()+", "+idade;
        }
    }
}
