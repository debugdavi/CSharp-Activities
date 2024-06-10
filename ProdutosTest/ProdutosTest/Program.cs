using System;
using System.Globalization;

namespace ProdutosTest {
    class Program {
        static void Main(string[] args) {
            Produto P = new Produto("TV 4K", 400.00, 10);

            P.Nome = "TESAO";
            Console.WriteLine(P.Nome);
            Console.WriteLine(P.Preco);
        }
    }
}