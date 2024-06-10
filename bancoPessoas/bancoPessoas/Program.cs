using System;
using System.Globalization;
namespace bancoPessoas {
    class Program {
        public static void Main(string[] args) {
            Conta p1;
            Console.WriteLine("Entre o numero da conta");
            string numC = Console.ReadLine();
            Console.WriteLine("Entre o titular da conta");
            string titul = Console.ReadLine();
            Console.WriteLine("Havera deposito inicial s ou n?");
            string resp = Console.ReadLine();

            if (resp == "s" || resp == "S") {
                Console.WriteLine("Digite o valor do deposito inicial");
                double valini = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p1 = new Conta(numC, titul, valini);
            }
            else {
                p1 = new Conta(numC, titul);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(p1);
            Console.WriteLine("\n");

            Console.WriteLine("Entre um valor para deposito: ");
            double valdep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p1.Deposito(valdep);


            Console.WriteLine("\n");
            Console.WriteLine("Dados da Conta atualizados");
            Console.WriteLine(p1);
            Console.WriteLine("\n");

            Console.WriteLine("Entre um valor para saque: ");
            double valsaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p1.Saque(valsaq);

            Console.WriteLine("\n");
            Console.WriteLine("Dados da Conta atualizados");
            Console.WriteLine(p1);
            Console.WriteLine("\n");

        }
    }
}