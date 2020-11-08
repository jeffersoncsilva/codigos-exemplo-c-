using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donwcast_Upcasting_Tipos_Nao_Basicos
{
    class Elefante : Animal
    {
        public Elefante(string nome): base(nome) { }

        public void Barulho()
        {
            Console.WriteLine("\nfroomm from from \n");
        }
    }
}
