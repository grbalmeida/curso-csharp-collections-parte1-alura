using System;
using System.Collections.Generic;
using System.Linq;

// LIFO -> Last in First out (Stack)
// FIFO -> First in First out (Queue)
namespace Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            // entrou: van
            Enfileirar("van");
            // van

            // entrou: kombi
            Enfileirar("kombi");
            // van | kombi

            // entrou: guincho
            Enfileirar("guincho");
            // van | kombi | guincho

            // entrou: pickup
            Enfileirar("pickup");
            // van | kombi | guincho | pickup

            // carro liberado
            Desenfileirar();
            // kombi | guincho | pickup

            // carro liberado
            Desenfileirar();
            // guincho | pickup

            // carro liberado
            Desenfileirar();
            // pickup

            // carro liberado
            Desenfileirar();
            // []

            try
            {
                Desenfileirar();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                // Lança InvalidOperationException ao tentar remover elemento da fila se ela estiver vazia
            }

            Console.ReadLine();
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");

            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                // .Peek() retorna primeiro elemento da fila sem remover
                // .Dequeue() retorna primeiro elemento da fila mas remove
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento.");
                }

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA:");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
