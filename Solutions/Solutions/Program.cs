using System;
using System.Globalization;
namespace Solutions {
    class Program {
        static void Main(string[] args) {
            double[] quebrados = new double[100];
            for (int i = 0; i < quebrados.Length; i++) {
                quebrados[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < quebrados.Length; i++){
                if (quebrados[i] <= 10) {
                    Console.WriteLine($"A[{i}] = {quebrados[i].ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}