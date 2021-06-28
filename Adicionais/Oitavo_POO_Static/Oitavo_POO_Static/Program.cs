using System;
using System.Globalization;

namespace Oitavo_POO_Static {
    class Program {
        static void Main(string[] args) {
            ConversorDeMoeda Cdm = new ConversorDeMoeda();

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = ConversorDeMoeda.calculo(compra, cotacao);

            Console.Write("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
