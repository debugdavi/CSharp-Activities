namespace Matrizes {
    class Program {
        public static void Main() {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i = 0; i <  n; i++) {
                for (int j = 0; j < m; j++) {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int val = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (matriz[i, j] == val) {

                    }
                }
            }


        }
    }
}