using System.Globalization;

namespace AtividadesNelio {
    class Program {
        static void Main() {
            Funcionario fun = new Funcionario();

            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.SalLiquido();

            Console.WriteLine("Funcionario: " + fun);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentaSal(porc);

            Console.WriteLine("Dados atualizados: " + fun);

        }
    }
}