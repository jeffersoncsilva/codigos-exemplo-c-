using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donwcast_Upcasting_Tipos_Nao_Basicos
{
    class Rato : Animal
    {
        public Rato(string nome) : base(nome) { }

        public void BarulhoDeRato()
        {
            Console.WriteLine("\nBarulho de rato aqui.\n");
        }

    }
}
