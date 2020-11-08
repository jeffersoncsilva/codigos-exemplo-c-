using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donwcast_Upcasting_Tipos_Nao_Basicos
{
    class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {

        }

        public void Latir()
        {
            Console.WriteLine("\nAu Au Au\n");
        }

    }
}
