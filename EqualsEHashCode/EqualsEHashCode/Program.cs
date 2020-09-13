using System;
using System.Collections.Generic;

namespace EqualsEHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Imprimindo os alunos matriculados");

            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));

            Console.WriteLine("a1 == a Tonini?");
            Console.WriteLine(a1 == tonini);
            Console.WriteLine(a1.Equals(tonini));

            Console.ReadLine();
        }
    }
}
