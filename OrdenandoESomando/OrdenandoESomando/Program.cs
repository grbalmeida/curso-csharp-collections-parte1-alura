using System;
using System.Collections.Generic;

namespace OrdenandoESomando
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            // Ao tentar adicionar uma nova aula em uma lista somente leitura lança NotSupportedException

            Imprimir(csharpColecoes.Aulas);

            // adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

            // imprimir
            Imprimir(csharpColecoes.Aulas);

            // ordenar a lista de aulas
            // csharpColecoes.Aulas.Sort();

            // copiar a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            // ordenar a cópia
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            // totalizar o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);

            Console.ReadLine();
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
