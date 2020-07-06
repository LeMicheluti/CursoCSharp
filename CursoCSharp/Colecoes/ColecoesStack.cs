using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            // Obtem o proximo valor do topo da pilha e a remove
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            // Obtem o proximo valor do topo da pilha porem não remove
            Console.WriteLine($"\nPeek: {pilha.Peek()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
