using System;

namespace Vetor {
    class Program {
        static void Main(string[] args) {
            Aluguel[] vect = new Aluguel[10];    

            Console.Write("Quantos Quartos serão alugados? ");
            int count = int.Parse(Console.ReadLine());

            Console.Write("");

            for (int i = 1; i <= count; i++) {
                Console.Write("Aluguel #{0}:", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Aluguel(nome, email);
            }

            for (int i = 1; i <= 10; i++) {
                if (vect[i] != null) {
                    Console.Write(i + ": " + vect[i]);
                }
            }           
        }
    }
}
