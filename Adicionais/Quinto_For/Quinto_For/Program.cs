using System;
using System.Globalization;

namespace Quinto_For {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escreva um número: ");
            int num = int.Parse(Console.ReadLine());
            

            for (int i = 0; i <= num; i ++) {
                double quadrado = Math.Pow(i, 2);
                double cubo = Math.Pow(i, 3);



                Console.WriteLine("{0} {1} {2}", i, quadrado, cubo);
            }
        }
    }
}
