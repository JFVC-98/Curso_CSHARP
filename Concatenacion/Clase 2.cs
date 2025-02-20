using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1
{
    class Clase_2
    {
        public void Escoge(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Chavez");
                    break;
                case 2:
                    Console.WriteLine("Mundo!!");
                    break;
                default:
                    Console.WriteLine("No se reconoce el valor");
                    break;
            }
        }
    }
}
