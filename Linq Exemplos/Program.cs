using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Exemplos
{
    class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student {FirstName="Svetlana", LastName="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {FirstName="Claire", LastName="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {FirstName="Sven", LastName="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {FirstName="Cesar", LastName="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {FirstName="Debra", LastName="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {FirstName="Fadi", LastName="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
            new Student {FirstName="Hanying", LastName="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
            new Student {FirstName="Hugo", LastName="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
            new Student {FirstName="Lance", LastName="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
            new Student {FirstName="Terry", LastName="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
            new Student {FirstName="Eugene", LastName="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
            new Student {FirstName="Michael", LastName="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}},
            new Student {FirstName="Eugenio", LastName="Lister", ID=123, Scores= new List<int> {66, 60, 45, 55}}
        };
        
        static List<Carro> cars = new List<Carro>()
            {
                new Carro {Nome="Gol", ModeloId=1},
                new Carro {Nome="Golf", ModeloId=1},
                new Carro {Nome="Civic", ModeloId=2},
            };
        
        static List<Fabricante> fabs = new List<Fabricante>()
            {
                new  Fabricante{Nome = "Volksvagem", Id = 1},
                new  Fabricante{Nome = "Honda", Id = 2},
                new  Fabricante{Nome = "Ferrari", Id = 3},
                new  Fabricante{Nome = "Mercedes", Id = 4}
            };

        static void Main(string[] args)
        {
            LinqsImportantes();
            LinqJoin();
            LinqJoin2();
            LinqParaConjuntos();
            Console.ReadLine();
        }

        static void LinqJoin()
        {
            var query = from c in cars
                        join m in fabs
                        on c.ModeloId equals m.Id
                        orderby c.Nome
                        select new { nome = c.Nome, fabricante = m.Nome };
            foreach (var v in query)
                Console.WriteLine($"Nome carro: {v.nome} -- fabricante: {v.fabricante}");
        }

        static void LinqJoin2()
        {
            var res = cars.AsEnumerable().Join(fabs.AsEnumerable(), car => car.ModeloId, fab => fab.Id, (car, fab) => new {
                nomeCarro = car.Nome,
                nomeFabricante = fab.Nome
            }).OrderBy(x => x.nomeFabricante);
            foreach (var v in res)
                Console.WriteLine($"Nome carro: {v.nomeCarro} --- Fabricante: {v.nomeFabricante}");
        }

        static void LinqsImportantes()
        {
            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<Student> filtro = from s in students where s.Scores[0] > 90 select s;
            foreach (Student stu in filtro)
                Console.WriteLine(stu.FirstName);


            Console.WriteLine("\n--------------------------------------------");
            var f5 = from st in students group st by st.FirstName[0] into studentGroup orderby studentGroup.Key select studentGroup;
            foreach (var group in f5)
            {
                Console.WriteLine($"------------------{group.Key}");
                foreach (Student stu in group)
                    Console.WriteLine(stu.FirstName);
            }


            Console.WriteLine("\n--------------------------------------------");
            var f6 = from st4 in students
                     let pontos = st4.Scores[0] + st4.Scores[1] + st4.Scores[2] + st4.Scores[3]
                     where pontos / 4 < st4.Scores[0]
                     select st4.LastName + " " + st4.FirstName;
            foreach (var v8 in f6)
                Console.WriteLine(v8);

            Console.WriteLine("\n--------------------------------------------");
            var f7 = from sst in students let pontos = sst.Scores[0] + sst.Scores[1] + sst.Scores[2] + sst.Scores[3] select pontos;
            var media = f7.Average();
            Console.WriteLine("Media de notas: {0}", media);


            Console.WriteLine("\n--------------------------------------------");
            var f9 = from st10 in students
                     let x = st10.Scores[0] + st10.Scores[1] + st10.Scores[2] + st10.Scores[3]
                     where x > media
                     select new { id = st10.ID, score = x };
            foreach (var v11 in f9)
                Console.WriteLine($"ID: {v11.id} --- Pontos: {v11.score}");


        }

        #region

        static void SimplesLinqs()
        {
            
            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<Student> filtro = from s in students where s.Scores[0] > 90 select s;
            foreach (Student stu in filtro)
                Console.WriteLine(stu.FirstName);



            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<Student> f2 = from s in students orderby s.FirstName select s;
            foreach (Student stu in f2)
                Console.WriteLine(stu.FirstName);



            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<Student> f3 = from s in students orderby s.FirstName descending select s;
            foreach (Student stu in f3)
                Console.WriteLine(stu.FirstName);


            
            Console.WriteLine("\n--------------------------------------------");
            var f4 = from st in students orderby st.LastName group st by st.LastName[0];
            foreach (var group in f4)
            {
                Console.WriteLine($"-------------------{group.Key}");
                foreach (Student stu in group)
                    Console.WriteLine(stu.LastName);
            }

            
            Console.WriteLine("\n--------------------------------------------");
            var f5 = from st in students group st by st.FirstName[0] into studentGroup orderby studentGroup.Key select studentGroup;
            foreach (var group in f5)
            {
                Console.WriteLine($"------------------{group.Key}");
                foreach (Student stu in group)
                    Console.WriteLine(stu.FirstName);
            }

            
            Console.WriteLine("\n--------------------------------------------");
            var f6 = from st4 in students
                     let pontos = st4.Scores[0] + st4.Scores[1] + st4.Scores[2] + st4.Scores[3]
                     where pontos / 4 < st4.Scores[0]
                     select st4.LastName + " " + st4.FirstName;
            foreach (var v8 in f6)
                Console.WriteLine(v8);
            
            Console.WriteLine("\n--------------------------------------------");
            var f7 = from sst in students let pontos = sst.Scores[0] + sst.Scores[1] + sst.Scores[2] + sst.Scores[3] select pontos;
            var media = f7.Average();
            Console.WriteLine("Media de notas: {0}", media);


            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<string> f8 = from s9 in students where s9.LastName == "Garcia" select s9.FirstName;
            foreach (var v10 in f8)
                Console.WriteLine(v10);




            Console.WriteLine("\n--------------------------------------------");
            var f9 = from st10 in students
                     let x = st10.Scores[0] + st10.Scores[1] + st10.Scores[2] + st10.Scores[3]
                     where x > media
                     select new { id = st10.ID, score = x };
            foreach (var v11 in f9)
                Console.WriteLine($"ID: {v11.id} --- Pontos: {v11.score}");



            Console.WriteLine("\n--------------------------------------------");
            //IEnumerable<IGrouping<string, int>> 
                var resultadoFinal = from alunos in students
                                 let x = (from m in alunos.Scores select m).Average()
                                 orderby alunos.FirstName
                                 select new { nome = alunos.FirstName, media = x };

            foreach (var al in resultadoFinal)
                Console.WriteLine($"Nome: {al.nome} -- Média: {al.media}");
            
        }

        static void SimplesLinsq2()
        {
            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<Student> filtro = students.Where(s => s.Scores[0] > 80);
            foreach (Student stu in filtro)
                Console.WriteLine(stu.FirstName);

            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<Student> f2 = students.OrderBy(s => s.FirstName);
            foreach (Student stu in f2)
                Console.WriteLine(stu.FirstName);

            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<Student> f3 = students.OrderByDescending(s => s.FirstName);
            foreach (Student stu in f3)
                Console.WriteLine(stu.FirstName);



            Console.WriteLine("\n--------------------------------------------");
            var f4 = students.OrderBy(s => s.LastName).GroupBy(s => s.LastName[0]);
            foreach (var group in f4)
            {
                Console.WriteLine($"-------------------{group.Key}");
                foreach (Student stu in group)
                    Console.WriteLine(stu.LastName);
            }




            Console.WriteLine("\n--------------------------------------------");
            var f6 = students.Where(s => s.Scores.Sum() / 4 < s.Scores[0]).Select(s => s.LastName + ", " + s.FirstName);
            foreach (var v8 in f6)
                Console.WriteLine(v8);


            Console.WriteLine("\n--------------------------------------------");
            var f7 = students.Select(s => s.Scores.Sum());
            var media = f7.Average();
            Console.WriteLine("Media de notas: {0}", media);


            Console.WriteLine("\n--------------------------------------------");
            IEnumerable<string> f8 = students.Where(s => "Garcia".Equals(s.LastName)).Select(s => s.FirstName);
            foreach (var v10 in f8)
                Console.WriteLine(v10);



            Console.WriteLine("\n--------------------------------------------");
            var f9 = students.Select(s => new { id = s.ID, score = s.Scores.Sum() }).Where(s => s.score > media);
            foreach (var v11 in f9)
                Console.WriteLine($"ID: {v11.id} --- Pontos: {v11.score}");



            Console.WriteLine("\n--------------------------------------------");
            //IEnumerable<IGrouping<string, int>> 
            var f10 = students.Select(s => new { nome = s.FirstName, media = s.Scores.Average() }).OrderBy(s => s.nome);
            foreach (var al in f10)
                Console.WriteLine($"Nome: {al.nome} -- Média: {al.media}");

        }

        static void LinqParaConjuntos()
        {
            List<string> carro = new List<string> { "Gol", "HB20", "Uno", "Celta", "Civic" };
            List<string> carro2 = new List<string> { "Gol", "HB20", "Uno", "Civic", "Palio", "Audi", "City" };
            List<string> motos = new List<string> { "CB Twister", "Titan 160", "Factor 125", "CB 1000" };

            Console.WriteLine("UNIAO---------------------------");
            var uniao = (from c in carro select c).Union(from m in motos select m).OrderBy(x => x);
            foreach (var v in uniao)
                Console.WriteLine(v);

            Console.WriteLine("INTERSECAO---------------------------");
            var intersecao = (from c in carro select c).Intersect(from c2 in carro2 select c2);
            foreach(var v in intersecao)
                Console.WriteLine(v);

            Console.WriteLine("CONCATENACAO---------------------------");
            var concatenacao = (from c in carro select c).Concat(from c2 in carro2 select c2).OrderBy(x => x);
            foreach(var v in concatenacao)
                Console.WriteLine(v);

            Console.WriteLine("DIFERENCA---------------------------");
            var diff = (from c in carro select c).Except(from c2 in carro2 select c2).OrderBy(x => x);
            foreach (var v in diff)
                Console.WriteLine(v);
        }
        #endregion
    }

    struct Carro
    {
        public string Nome { get; set; }
        public int ModeloId { get; set; }
    }

    struct Fabricante
    {
        public string Nome { get; set; }
        public int Id { get; set; }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
    }

}
