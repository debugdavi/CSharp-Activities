using System;
using System.Globalization;
namespace TesteString {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escreva um dia e horário. Exemplo '2000/08/15T13:05:58Z'");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(d1);
            Console.WriteLine(d1.Kind);

            Console.WriteLine(d1.ToLocalTime());
            Console.WriteLine(d1.ToUniversalTime());

        }
    }
}