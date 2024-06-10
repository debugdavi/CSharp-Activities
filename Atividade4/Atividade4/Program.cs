using System;
using System.Globalization;

namespace Atividade4 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.CalcCirc(raio);
            double vol = Calculadora.CalcVol(raio);

            Console.WriteLine("Circunferencia: " +  circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}