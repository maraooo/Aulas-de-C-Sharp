using System;

namespace Quarto_While {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escreva o codigo: ");
            int num = int.Parse(Console.ReadLine());

            int alcool = 0, gasolina = 0, diesel = 0;


            while (num != 4) {
                if (num == 1) {
                    alcool++;
                }
                else if (num == 2) {
                    gasolina++;
                }
                else if (num == 3) {
                    diesel++;
                }
                else {

                }

                Console.WriteLine("Escreva o codigo:  ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Certin Marão!!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
