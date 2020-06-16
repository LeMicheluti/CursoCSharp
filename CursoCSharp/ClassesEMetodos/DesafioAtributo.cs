using System;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10; //Atributo de instância
        public static void Executar()
        {
            // Acessar variável 'a' dentro do método executar!
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
