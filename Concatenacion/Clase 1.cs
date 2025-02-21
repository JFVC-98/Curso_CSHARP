using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1
{
    class Clase_1
    {
        public void Imprimir() => Console.WriteLine("Hola Mundo!!");
        public void Escoge(int a,string lol)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Valles");
                    break;
                case 2:
                    Console.WriteLine("Adios Mundo!!");
                    break;
                default:
                    Imprimir();
                    break;
            }
        }
        public string Nuevo(int a, string lol)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Valles");
                    break;
                case 2:
                    Console.WriteLine("Adios Mundo!!");
                    break;
                default:
                    Imprimir();
                    break;
            }
            return "Hola";
        }
    }
}
