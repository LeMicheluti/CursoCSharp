using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou a TV 50? {comprouTV50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou sorverte? {comprouSorvete}");

            bool comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou TV 32? {comprouTV32}");

            Console.WriteLine("Mair Saldável? {0}", !comprouSorvete);
        }
    }
}
