namespace MembrosEstaticos2 {
    internal class Calculadora {

        public static double PI = Math.PI;

        public static double Circunferencia(double r) {
            return 2.0 * Math.PI * r;
        }

        public static double Volume(double r) {
            return 4.0 / 3.0 * Math.PI * Math.Pow(r, 3.0);
        }
    }
}
