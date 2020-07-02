using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("A");
            fila.Enqueue("B");
            fila.Enqueue("C");

            // Mostra o primeiro valor da fila sem retirar da fila
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            // Mostra e retira o primeiro valor da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
