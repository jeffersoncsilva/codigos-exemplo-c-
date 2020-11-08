using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donwcast_Upcasting_Tipos_Nao_Basicos
{
    abstract class Animal
    {
        public char Sexo { get;  set; }
        public string Nome { get; protected set; }

        public Animal(string nome) { this.Nome = nome; }

        public override string ToString()
        {
            return $"Nome: {Nome} -- Sexo: {Sexo}";
        }

    }
}
