using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa(); //instancia
            pessoa.Nome = "Renato";
            pessoa.Idade = 21;

            Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos.");
            pessoa.ApresentarNoConsole();
            pessoa.Zerar();
            pessoa.ApresentarNoConsole();

            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Beto";
            pessoa2.Idade = 22;

            var apresentacaoDoFulano = pessoa2.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
