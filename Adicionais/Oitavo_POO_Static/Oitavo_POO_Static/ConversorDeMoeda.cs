namespace Oitavo_POO_Static {
    class ConversorDeMoeda {
        public static double Iof = 6.0;

        public static double calculo(double compra, double cotacao) {
            double total = compra * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
