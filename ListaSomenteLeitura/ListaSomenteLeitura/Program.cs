using System;
using System.Collections.Generic;

namespace ListaSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            // Ao tentar adicionar uma nova aula em uma lista somente leitura lança NotSupportedException

            Imprimir(csharpColecoes.Aulas);

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
