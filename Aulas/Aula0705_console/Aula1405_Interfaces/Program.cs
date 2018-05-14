using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            Console.WriteLine("Velocidade inicial do Carro:" + car.Velocidade);
            AcelerarBastante(car);
            Console.WriteLine(car.ImprimirInfo());
            car.Desacelerar();
            car.Desacelerar();
            Console.WriteLine("Velocidade Final do Carro:" + car.Velocidade+"\n");
            Onibus bus = new Onibus();
            Console.WriteLine("Velocidade Inicial do Onibus:"+bus.Velocidade);
            AcelerarBastante(bus);
            Console.WriteLine(bus.ImprimirInfo());
            bus.Desacelerar();
            Console.WriteLine("Velocidade Final do Ônibus:" + bus.Velocidade);
            Console.ReadKey();
        }

       public static void AcelerarBastante(MeioTransporte meioTransporte)
        {
            for (int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }

        }

        static void CrirarRelacionamentos()
        {
            Carro c = new Carro();
            c.Modelo = "Corsa";

            Marca m = new Marca();
            m.Nome = "Chevrolet";
            c._Marca = m;

            Onibus o = new Onibus();
            o.Modelo = "3100";
            o._Marca = m;
        }
    }
}
