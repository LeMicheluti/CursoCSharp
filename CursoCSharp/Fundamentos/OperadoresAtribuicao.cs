using System;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num = 3;
            num = 7;
            num += 10; // num = num + 10;
            num -= 3; //  num = num - 3;
            num *= 5; // num = num * 5;
            num /= 2; // num = num / 2;

            Console.WriteLine(num);

            int a = 1;
            int b = a;

            a++; // a = a + 1; operador unário de incremento
            b--; // b = b - 1; operador unário de decremento

            Console.WriteLine($"{a} , {b}");

            //Atribuição por referência
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);

        }
    }
}
