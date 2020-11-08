using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Genericos
{
    class Program
    {
        struct Relacao : IComparable
        {
            public string nome;
            public int id;

            public int CompareTo(object obj)
            {
                if (obj is Relacao r && r.id > id)
                    return 1;
                else if (obj is Relacao r2 && r2.id < id)
                    return -1;
                else
                    return 0;
            }

            public override string ToString()
            {
                return $"Nome: {nome} -- Id: {id}";
            }

            public override bool Equals(object obj)
            {
                return (obj is Relacao r) && r.GetHashCode() == GetHashCode();
            }

            public override int GetHashCode()
            {
                return nome.GetHashCode();
            }

        }

        struct Coordenadas<T>
        {
            public T X { get; set; }
            public T Y { get; set; }
            public T Z { get; set; }

            public Coordenadas(T xV, T yV, T zV)
            {
                X = xV;
                Y = yV;
                Z = zV;
            }

            public override string ToString()
            {
                return $"[{X},{Y},{Z}]";
            }
        }

        static void Main(string[] args)
        {
            List<Relacao> lst = CriarLista();
            Stack<int> pilha = CriaPilha();
            Queue<int> fila = CriaFila();
            SortedSet<Relacao> set = CriaSortedSet(lst);
            Dictionary<string, Relacao> dict = CriaDictionary(lst);
            Dictionary<int, Relacao> dict2 = CriaDictionary2();
            //MetodosPrincipaisLista(lst);
            //WorkDictionary(dict);
            //CoordenadasExemplo();
            UtilExemplo();
            Console.ReadLine();
        }

        static void UtilExemplo()
        {
            Relacao a = new Relacao { nome = "AA", id = 1 };
            Relacao b = new Relacao { nome = "BB", id = 2 };
            Console.WriteLine("a: {0} --- b: {1}", a.ToString(), b.ToString());
            Util.Swap<Relacao>(ref a, ref b);
            Console.WriteLine("a: {0} --- b: {1}", a.ToString(), b.ToString());

            int ab = 11, bb = 99;
            Console.WriteLine("a: {0} --- b: {1}", ab, bb);
            Util.Swap<int>(ref ab, ref bb);
            Console.WriteLine("a: {0} --- b: {1}", ab, bb);
        }

        static void CoordenadasExemplo()
        {
            Coordenadas<int> cc = new Coordenadas<int>(0, 0, 0);
            Coordenadas<long> ll = new Coordenadas<long>(345, 234, 668);
            Coordenadas<double> dd = new Coordenadas<double>(1.5, 2.5, 2.8);
            Coordenadas<float> ff = new Coordenadas<float>(1.5f, 2.5f, 2.8f);

            Coordenadas<Relacao> rr = new Coordenadas<Relacao>(new Relacao { nome = "X", id = 4 }, new Relacao { nome = "Y", id = 44 }, new Relacao { nome = "Z", id = 8 });

            Console.WriteLine("Coordenadas<int>: {0}", cc.ToString());
            Console.WriteLine("Coordenadas<long>: {0}", ll.ToString());
            Console.WriteLine("Coordenadas<double>: {0}", dd.ToString());
            Console.WriteLine("Coordenadas<float> ff: {0}", ff.ToString());
            Console.WriteLine("Coordenadas<Relacao>: {0}", rr.ToString());

        }

        static void WorkDictionary(Dictionary<string, Relacao> dict)
        {
            Relacao r = dict["dict_8"];
            Console.WriteLine(r.ToString());
            foreach(var v in dict)
                Console.WriteLine($"Chave: {v.Key} -- Valor: {v.Value}");
            
            Console.WriteLine("\nChaves com id >= 5 n");
            var res = from p in dict where p.Value.id >= 5 select p;
            foreach (var v in res)
                Console.WriteLine($"Chave: {v.Key} -- Valor: {v.Value}");

            var re = dict.Where(x => x.Value.id >= 7).ToList();
            foreach (var vvv in re)
                dict.Remove(vvv.Key);
            Console.WriteLine("\nChaves com id >= 7 apagadas n");

            foreach (var v in dict.OrderBy(x => x.Value.id))
                Console.WriteLine($"Chave: {v.Key} -- Valor: {v.Value}");

        }

        static void MetodosPrincipaisFila(Queue<int> fila)
        {
            if (fila.Contains(58))
                Console.WriteLine("A fila tem o número 58.");
            else
                Console.WriteLine("A fila não tem o número 58");
            Console.WriteLine("Topo da fila: {0}", fila.Peek());
            Console.WriteLine("Tamanho: {0}", fila.Count());
            fila.Dequeue();
            Console.WriteLine("Tamanho: {0}", fila.Count());
        }

        static void MetodosPrincipaisPilha(Stack<int> pilha)
        {
            if (pilha.Contains(58))
                Console.WriteLine("A fila tem o número 99.");
            else
                Console.WriteLine("A fila não tem o número 99");
            Console.WriteLine("Topo da fila: {0}", pilha.Peek());
            Console.WriteLine("Tamanho: {0}", pilha.Count());
            pilha.Pop();
            Console.WriteLine("Tamanho: {0}", pilha.Count());
        }

        static void MetodosPrincipaisLista(List<Relacao> lst)
        {
            if (lst.Contains(new Relacao { nome = "Ban", id = 2 }))
            {
                Console.WriteLine("Tem a relação.");
            }
            else
                Console.WriteLine("Não tem a relação.");
            
            Console.WriteLine("Existe id 4: {0}", lst.Exists(x => x.id == 5));
            Relacao r = lst[3];
            Console.WriteLine(r.ToString());
            lst.Remove(r);
            Console.WriteLine("Tamanho: {0}", lst.Count);
            lst.RemoveAt(9);
            Console.WriteLine("Tamanho: {0}", lst.Count);
            lst.RemoveAll(x=> x.id <= 5);
            Console.WriteLine("Tamanho: {0}", lst.Count);
        }

        static List<Relacao> CriarLista()
        {
            List<Relacao> lst = new List<Relacao>();
            lst.Add(new Relacao { nome = "Mecherica", id = 10 });
            lst.Add(new Relacao { nome = "Ban", id = 2 });
            lst.Add(new Relacao { nome = "Laranja", id = 9 });
            lst.Add(new Relacao { nome = "Maçã", id = 5 });
            lst.Add(new Relacao { nome = "Banana", id = 1 });
            lst.Add(new Relacao { nome = "Maracujá", id = 8 });
            lst.Add(new Relacao { nome = "Morango", id = 6 });
            lst.Add(new Relacao { nome = "Uva", id = 4 });
            lst.Add(new Relacao { nome = "Abacate", id = 3 });
            lst.Add(new Relacao { nome = "Abacate", id = 7 });
            return lst;
        }

        static Stack<int> CriaPilha()
        {
            Stack<int> pilha = new Stack<int>();
            pilha.Push(10);
            pilha.Push(3);
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(9);
            pilha.Push(8);
            pilha.Push(4);
            pilha.Push(7);
            pilha.Push(5);
            pilha.Push(6);
            return pilha;
        }

        static Queue<int> CriaFila()
        {
            Queue<int> fila = new Queue<int>();
            fila.Enqueue(10);
            fila.Enqueue(8);
            fila.Enqueue(2);
            fila.Enqueue(6);
            fila.Enqueue(7);
            fila.Enqueue(3);
            fila.Enqueue(5);
            fila.Enqueue(1);
            fila.Enqueue(4);
            fila.Enqueue(9);
            return fila;
        }

        static Dictionary<int, Relacao> CriaDictionary2()
        {
            Dictionary<int, Relacao> dict2 = new Dictionary<int, Relacao>()
            {
                {1, new Relacao{nome="Marge", id=50} },
                {2, new Relacao{nome="Homer", id=55} },
                {3, new Relacao{nome="Lisa", id=9} },
                {4, new Relacao{nome="Barg", id=10} },
                {5, new Relacao{nome="Maggie", id=2} }
            };
            return dict2;
        }

        static Dictionary<string, Relacao> CriaDictionary(List<Relacao> lst)
        {
            Dictionary<string, Relacao> dict = new Dictionary<string, Relacao>();
            foreach (Relacao c in lst)
            {
                string str = $"dict_{c.id}";
                dict.Add(str, c);
            }
            return dict;
        }

        static SortedSet<Relacao> CriaSortedSet(List<Relacao> lst)
        {
            SortedSet<Relacao> set = new SortedSet<Relacao>();
            foreach (Relacao r in lst)
            {
                set.Add(r);
            }
            return set;
        }

    }

    internal static class Util
    {
        public static void Show<T>()
        {
            Console.WriteLine($"type: {0} --- baseType: {1}", typeof(T), typeof(T).BaseType);
        }

        public static void Swap<T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}