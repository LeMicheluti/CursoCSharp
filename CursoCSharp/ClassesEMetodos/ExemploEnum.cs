using System;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filme = new Filme();
            filme.Titulo = "Sharknado 17";
            filme.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filme.Titulo, filme.GeneroDoFilme);
        }
    }
}
