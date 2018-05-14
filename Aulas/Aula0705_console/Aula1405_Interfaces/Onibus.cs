using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Onibus : MeioTransporte
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

        public void Acelerar()
        {
            Velocidade += 5;
        }

        public void Desacelerar()
        {
            Velocidade -= 5;
        }

        public string ImprimirInfo()
        {
            return "Ônibus, Velocidade Atual:" + Velocidade;
        }



    }
}
