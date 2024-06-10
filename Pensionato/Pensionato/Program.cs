namespace Pensionato {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos quartos vão ser ocupados?");
            int ocup = int.Parse(Console.ReadLine());
            Quarto[] quarto = new Quarto[10];

            for (int i = 0; i < ocup; i++) {
                Console.Write("Rent #{0}:\n", i + 1);
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int reser = int.Parse(Console.ReadLine());
                quarto[reser] = new Quarto(nome, email);
                Console.Write("\n");
            }

            Console.WriteLine("Recibos de Aluguel");
            for (int i = 0;i < quarto.Length; i++) {
                if (quarto[i] != null) {
                    
                    Console.WriteLine("{0} Rent: {1}, {2}", i, quarto[i].Aluno, quarto[i].Email);
                }
            }
        }
    }
}