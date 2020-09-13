using System;
using System.Collections.Generic;

namespace OPoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //SETS = CONJUNTOS

            //Duas propriedades do Set
            //1. não permite duplicidade
            //2. os elementos não são mantidos em ordem específicas

            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(",", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(",", alunos));

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            Console.WriteLine(string.Join(",", alunos));

            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(",", alunos));

            // qual a vantagem do set sobre a lista?
            // conjuntos são mais rápidos em buscar elementos
            // HashSet possui grande escalabilidade
            // Ponto fraco do HashSet é o consumo de memória ao lidar com grande quantidade de elementos

            // alunos.Sort()

            List<string> alunosEmLista = new List<string>(alunos);

            alunosEmLista.Sort();

            Console.WriteLine(string.Join(",", alunosEmLista));

            Console.ReadLine();
        }
    }
}
