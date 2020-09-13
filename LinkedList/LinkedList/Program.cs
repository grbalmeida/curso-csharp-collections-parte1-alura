using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imagine uma lista de frutas
            List<string> frutas = new List<string>
            {
                "abacate",
                "banana",
                "caqui",
                "damasco",
                "figo"
            };

            // Vamos imprimir essa lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            // Armazenamento em memória
            // | abacate | banana | caqui | damasco | figo |        |        |
            // Armazenamento em array interno na lista com posições sequenciais na memória

            // Adicionar um elemento ao final de uma lista é rápido

            // Porém inserir no meio da lista exige mais esforço computacional

            // E para adicionar uma nova fruta entre a banana e o caqui?
            // Armazenamento em memória
            // | abacate | banana | caju | -> caqui | -> damasco | -> figo |          |
            // Temos que mover o caqui, o damasco e o figo para frente
            // Para que o caju fique entre a banana e o caqui

            // Exige-se mais poder computacional porque os elementos têm que ser deslocados
            // para darem espaço ao novo elemento!

            // E se tivermos que remover esse elemento, os elementos
            // seguintes precisam ser deslocados de novo
            // Armazenamento em memória
            // | abacate | banana | <- caqui | <- damasco | <- figo |          |

            // Quanto maior a lista, mais ineficiente é a inserção
            // e remoção de elementos no meio dela!

            // Que coleção é apropriada para inserção/remoção rápida?

            // Apresentando LISTA LIGADA (LINKED LIST):
            // - Elementos não precisam estar em sequência em memória
            // - Cada elemento sabe quem é o anterior e o próximo
            // - Cada elemento é um "nó" que contém um valor

            // Armazenamento em memória
            // | d4 | d2 | d3 | d6 | d7 | d5 | d1

            // Como a ordem é mantida? Usando ponteiros

            // Armazenamento em memória

            //         ------------------------|
            //         |                       |
            //         |                       |
            // | d4 | d2 | d3 | d6 | d7 | d5 | d1
            //    |    |------|  |    |    |   |
            //    |-----------|  |---------|   |
            //    -----------------------------|

            // Instanciando uma nova lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();

            // Adicionando um dia qualquer: "quarta"
            LinkedListNode<string> d4 = dias.AddFirst("quarta");
            // quarta é o primeiro elemento da lista ligada

            // Cada elemento é um nó: LinkedListNode<T>

            // Mas e valor "quarta"? Está na propriedade d4.Value

            Console.Clear();

            Console.WriteLine("d4.Value: " + d4.Value);

            // E para adicionar mais itens? LinkedList não possui o método Add!
            // Podemos adicionar de 4 formas:
            // 1. Como primeiro nó
            // 2. Como último nó
            // 3. Antes de um nó conhecido
            // 4. Depois de um nó conhecido

            // Vamos adicionar segunda, antes de quarta:

            LinkedListNode<string> d2 = dias.AddBefore(d4, "segunda");

            // d2 <-----> d4
            // Agora d2 e d4 estão ligados!

            // Como acessar um nó a partir de outro?
            // - d2.Next é igual a d4 pois pega o próximo nó

            Console.WriteLine(d2.Next);
            Console.WriteLine(d2.Next.Value);

            // - d4.Previous é igual a d2

            Console.WriteLine(d4.Previous);
            Console.WriteLine(d4.Previous.Value);

            // Continuando com nossa lista ligada,
            // vamos adicionar terça depois de segunda

            LinkedListNode<string> d3 = dias.AddAfter(d2, "terça");

            // Armazenamento em memória
            // d2 <---> d3 <---> d4

            // Perceba que os "ponteiros", ou referências
            // de d2 e d4 foram redirecionados para d3!
            // Vamos adicionar sexta depois de quarta

            LinkedListNode<string> d6 = dias.AddAfter(d4, "sexta");

            // Armazenamento em memória
            // d2 <---> d3 <---> d4 <---> d6

            // sábado depois de sexta

            LinkedListNode<string> d7 = dias.AddAfter(d6, "sábado");

            // Armazenamento em memória
            // d2 <---> d3 <---> d4 <---> d6 <---> d7

            // quinta antes de sexta

            LinkedListNode<string> d5 = dias.AddBefore(d6, "quinta");

            // Armazenamento em memória
            // d2 <---> d3 <---> d4 <---> d5 <---> d6 <---> d7

            // domingo antes de segunda

            LinkedListNode<string> d1 = dias.AddBefore(d2, "domingo");

            // Armazenamento em memória
            // d1 <---> d2 <---> d3 <---> d4 <---> d5 <---> d6 <---> d7

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            // LinkedList NÃO DÁ suporte ao acesso de índice: dias[0]
            // por isso podemos fazer um laço foreach mas não for um for!

            // LinkedList não é muito eficiente quando se precisa realizar muitas buscas
            LinkedListNode<string> quarta = dias.Find("quarta");

            // Para remover um elemento, podemos tanto
            // remover pelo valor quanto pela
            // referência do LinkedListNode

            dias.Remove("quarta");

            dias.Remove(d1);

            Console.ReadLine();
        }
    }
}
