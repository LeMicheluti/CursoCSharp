using System;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            string saudacao = "olá".ToUpper().Insert(3, "World!").Replace("World", " mundo");
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine($"Valor = {valorImportante?.Length}");
        }
    }
}
