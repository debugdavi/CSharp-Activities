using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListStudies { 
    class Program {
        static void Main(string[] args) {
            List<Funcionario> listaFunc = new List<Funcionario>();
            Funcionario fun;
            Console.Write("How many employees will be registered: ");
            int rep = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rep; i++) {
                Console.WriteLine($"Employee #{i}");
                Console.Write("ID: ");
                string idp = Console.ReadLine();
                Console.Write("Name: ");
                string namep = Console.ReadLine();
                Console.Write("Salary: ");
                double salp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun = new Funcionario(idp, namep, salp);
                listaFunc.Add(fun);
                Console.WriteLine("\n");
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            string pushid = Console.ReadLine();

            Funcionario desejado = listaFunc.Find(x => x.Id == pushid);

            if(desejado  != null) {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                desejado.AumentaSal(percentage);
            }
            else {
                Console.WriteLine("Funcionario não encontrado");
            }
            Console.WriteLine();

            foreach(Funcionario mostra in listaFunc) {
                Console.WriteLine(mostra.ToString());
            }
        }
    }
}