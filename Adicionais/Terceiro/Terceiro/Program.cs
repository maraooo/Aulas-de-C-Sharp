using System;
using System.Globalization;

namespace Terceiro {
    class Program {
        static void Main(string[] args) {
            string[] dados = Console.ReadLine().Split(' ');

            double x = double.Parse(dados[0], CultureInfo.InvariantCulture);
            double y = double.Parse(dados[1], CultureInfo.InvariantCulture);

            Console.WriteLine("----------------");

            if (x == 0 && y == 0.0) {
                Console.WriteLine("ORIGEM");
            }
            else if (x >= 0.1 && y >= 0.1) {
                Console.WriteLine("Q1");
            }
            else if (x >= 0.1 && y <= 0.1) {
                Console.WriteLine("Q4");
            }
            else if (x <= 0.1 && y >= 0.1) {
                Console.WriteLine("Q2");
            }
            else {
                Console.WriteLine("Q3");
            }
            
        }
    }
}
