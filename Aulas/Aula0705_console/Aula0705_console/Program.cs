using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0705_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Hello World");
            Console.WriteLine("a:" + a);

            if (Console.CapsLock)
                Console.WriteLine("Capslock ativado");
            else
                Console.WriteLine("Capslock desativado");

            Console.ReadLine();

        }
    }
}
