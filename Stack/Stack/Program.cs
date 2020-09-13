using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            Console.ReadLine();
        }
    }

    class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";

        public Navegador()
        {
            Console.WriteLine($"Página atual: {atual}");
        }

        public void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine($"Página atual: {atual}");
        }

        public void Anterior()
        {
            // Método Pop lança InvalidOperationException se a pilha estiver vazia
            
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
        }

        public void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
        }
    }
}
