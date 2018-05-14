using System;

namespace Aula1005_POO
{
    class Cliente : Pessoa
    {
        public DateTime DataNasc { get; set; }
        public int idade {
            get
            {

                int YearsAge = DateTime.Now.Year - DataQueNasceu.Year;
                // Se a data de aniversário não ocorreu ainda este ano, subtrair um ano a partir da idade
                if (DateTime.Now.Month < DataQueNasceu.Month || (DateTime.Now.Month == DataQueNasceu.Month && DateTime.Now.Day < DataQueNasceu.Day))
                {
                    ide = YearsAge--;
                }
                return  idade = YearsAge;

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
    }
}
