using System;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void ALterarOut(out int numero) // out é unidirecional
        {
            numero = 15;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            ALterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}
