using System;
using System.Collections.Generic;

namespace Dicionarios
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

            Console.Clear();

            Console.WriteLine("Quem é o aluno com matrícula 5617?");

            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);

            Console.WriteLine("aluno5617: " + aluno5617);

            // Um dicionário permite associar uma chave (no caso, matrícula)
            // a um valor (o aluno)

            Console.WriteLine("Quem é o aluno 5618?");

            try
            {
                Console.WriteLine("aluno5618: " + csharpColecoes.BuscaMatriculado(5618));
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
                // The given key was not present in the dictionary.
            }

            // E se tentarmos adicionar outro aluno com a mesma chave 5617?
            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            
            try
            {
                csharpColecoes.Matricula(fabio);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                // An item with the same key has already been added.
            }

            csharpColecoes.SubstituiAluno(fabio);

            Console.WriteLine("Quem é o Aluno 5617 agora?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5617));

            Console.ReadLine();
        }
    }
}
