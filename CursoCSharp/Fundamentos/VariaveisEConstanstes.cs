using System;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstanstes
    {
        public static void Executar()
        {
            // Área da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            bool estaChovendo = true; //tipo boleano
            Console.WriteLine("Está chovendo = " + estaChovendo);

            byte idade = 45; // Unico byte = 8 bits (aceita de 0 a 255)
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // aceita de -128 a 127
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            ushort maiorUShort = ushort.MaxValue; // 0 a 65,535
            Console.WriteLine("Maior valor UShort" + maiorUShort);

            short salario = short.MaxValue;// -32,768 a 32,767
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;// -2,147,483,648 a 2,147,483,647
            Console.WriteLine("Menor valor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;// 0 a 4,294,967,295
            Console.WriteLine("Populãção BR " + populacaoBrasileira);

            long menorValorLong = long.MinValue;// -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;// 0 a 18,446,744,073,709,551,615
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1299.99f; // -3.402823e38 a 3.402823e38
            Console.WriteLine("Preço PC " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;// -1.79769313486232e308 a 1.79769313486232e308
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;// -79228162514264337593543950335 a 79228162514264337593543950335
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

            char letra = 'b';// U+0000 a U+ffff
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo";
            Console.WriteLine("Texto = " + texto);
        }
    }
}
