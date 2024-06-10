using System.Globalization;
using System;

namespace Atividades3 {
    class Program {
        static void Main() {
            Aluno aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite as notas: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nfim();

            Console.WriteLine("Nota Final = " + aluno.NFinal);
            string fim = aluno.Nfim();
            Console.WriteLine(fim);

        }
    }
}