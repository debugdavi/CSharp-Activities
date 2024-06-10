using System;
using System.Globalization;

namespace AtividadesStatic {
    class Program {
        static void Main() {
            Console.Write("Qual e a cotacao do dolar? ");
            double ValDol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar? ");
            double QntDol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ValReal = ConversorDeMoeda.ValorDol(ValDol, QntDol);

            Console.WriteLine("Valor a ser pago em reais = R$" +  ValReal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}