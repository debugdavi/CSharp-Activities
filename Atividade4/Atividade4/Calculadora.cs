namespace Atividade4 {
    internal class Calculadora {
        public static double Pi = 3.14;
        public static double CalcCirc(double r) {
            return Pi * r * 2;
        }
        public static double CalcVol(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
