using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donwcast_Upcasting_Tipos_Nao_Basicos
{
    class Gato : Animal
    {
        public Gato(string nome) : base(nome) { }

        public void Miar()
        {
            Console.WriteLine("\nMiau Miau Miau\n");
        }

    }
}
