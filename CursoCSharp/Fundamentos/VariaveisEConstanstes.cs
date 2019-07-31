using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstanstes {
        public static void Executar() {
            // Área da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            bool estaChovendo = true; //tipo boleano
            Console.WriteLine("Está chovendo = " + estaChovendo);

            byte idade = 45; // Unico byte = 8 bits (aceita de 0 a 256)
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // aceita de -128 a 127
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Populãção BR " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço PC " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo";
            Console.WriteLine("Texto = " + texto);
        }
    }
}
