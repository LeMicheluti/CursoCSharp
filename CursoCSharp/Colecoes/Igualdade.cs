using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            // Compara o endereço de memória
            Console.WriteLine(p1 == p2); // false
            Console.WriteLine(p3 == p2); // true

            // Override metodo Equals para comparar os valores dos atributos
            Console.WriteLine(p1.Equals(p2)); // true

        }
    }
}
