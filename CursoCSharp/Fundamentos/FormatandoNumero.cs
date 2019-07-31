using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1")); //mostra um caractere
            Console.WriteLine(valor.ToString("C")); //valor monetario
            Console.WriteLine(valor.ToString("P")); //Porcentagem
            Console.WriteLine(valor.ToString("#.##")); //duas casas decimais

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura)); //mostra o valor monetario em dolar 

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //mostra o valor com 10 casas (zeros a esquerda)

        }
    }
}
