using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donwcast_Upcasting_Tipos_Nao_Basicos
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>();
            animais.Add(new Gato("Gatito")); // cast implicito aqui
            animais.Add(new Gato("Gatildo"));
            animais.Add(new Cachorro("Toto"));
            animais.Add(new Elefante("Pumba"));
            animais.Add(new Rato("Jerry"));

            //SimpleLinq(animais);
            AsExemplo(animais);
            //SimpleImplicityCast();

            Console.ReadLine();
        }

        static void AsExemplo(List<Animal> animais)
        {
            foreach(var v in animais)
            {
                Gato g = v as Gato;
                if (g != null)
                    g.Miar();
                Cachorro c = v as Cachorro;
                if (c != null)
                    c.Latir();
                Rato r = v as Rato;
                if (r != null)
                    r.BarulhoDeRato();
                Elefante e = v as Elefante;
                if (e != null)
                    e.Barulho();
            }
        }

        static void IsExemplo(List<Animal> animais)
        {
            foreach (var v in animais)
            {
                if (v is Gato g)
                {
                    Console.WriteLine("O nome do gato e: {0}", v.Nome);
                    g.Miar();
                }
                else if (v is Cachorro c)
                {
                    Console.WriteLine("O nome do cachorro e: {0}", v.Nome);
                    c.Latir();
                }
                else if (v is Rato r)
                {
                    Console.WriteLine("O nome do rato e: {0}", v.Nome);
                    r.BarulhoDeRato();
                }
                else if (v is Elefante e)
                {
                    Console.WriteLine("O nome do elefante e: {0}", v.Nome);
                    e.Barulho();
                }
            }
        }

        static void SimpleLinq(List<Animal> animais)
        {
            Rato r = (Rato)(from a in animais where a.Nome == "Jerry" select a).First();
            r.BarulhoDeRato();
            Gato g = (Gato)(from a in animais where a.Nome == "Gatito" select a).FirstOrDefault();
            Console.WriteLine(g.Nome);
            Cachorro c = (Cachorro)(from a in animais where a.Nome == "Toto" select a).First();
            c.Latir();
            Elefante e = (Elefante)(from a in animais where a.Nome == "Pumba" select a).FirstOrDefault();
        }

        static void SimpleImplicityCast()
        {
            Animal gato = new Gato("Milk");
            gato.Sexo = 'F';
            Console.WriteLine(gato.ToString());
            Animal cachorr = new Cachorro("Panthera");
            cachorr.Sexo = 'F';
            Console.WriteLine(cachorr.ToString());
            Animal el = new Elefante("Dumbo");
            el.Sexo = 'M';
            Console.WriteLine(el.ToString());
            Animal rato = new Rato("Jerry");
            Console.WriteLine(rato.ToString()); 
        }

    }
}
