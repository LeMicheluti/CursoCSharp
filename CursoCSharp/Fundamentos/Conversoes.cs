using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            #region conversão implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);
            #endregion

            #region conversão explicita
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado {idadeInteiro}");

            //evita erro ao digitar letras
            Console.Write("Digite o priemiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado 1 {numero}");

            Console.Write("Digite o priemiro número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado 2 {numero2}");

            #endregion 
        }
    }
}
