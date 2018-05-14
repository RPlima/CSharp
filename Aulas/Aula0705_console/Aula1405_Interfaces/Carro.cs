using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Carro : MeioTransporte
    {
        public int Velocidade { get; set; }
        //Chave para objeto Marca
        public int MarcaID { get; set; }
        //Propriedade de Navegação
        public virtual Marca _Marca { get; set; }

        public string Modelo
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Carro()
        {
            Velocidade = 0;
        }

        public void Acelerar()
        {
             Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 10;
        }

        public string ImprimirInfo()
        {
            return "Carro, Velocidade Atual:"+Velocidade;
        }
    }
}
