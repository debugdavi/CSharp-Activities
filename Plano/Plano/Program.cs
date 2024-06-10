using System;
using System.Globalization;

namespace Plano {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double med = 0; 
            Produtos[] produto = new Produtos[n];

            for (int i = 0; i < n; i++) { 
                string nome = Console.ReadLine();
                double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produto[i] = new Produtos(nome, preco);
                med = med + preco;
            }

            med = med / n;
            Console.WriteLine("Media de Preco deles" + med.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}