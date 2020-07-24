using CursoCSharp.ClassesEMetodos;
using System;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPRivado;
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
            valorPRivado = coisa;
        }

        public T MetodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPRivado;
        }
    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0) { }
    }

    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto()) { }
    }

    class Genericos
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.MetodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.MetodoGenerico("Método"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
