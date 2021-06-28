using System;
using System.Globalization;

namespace Secao5_POO_Final {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            int numconta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoincial = char.Parse(Console.ReadLine());

            Conta co = new Conta(numconta, nome);

            if (depositoincial == 's') {
                Console.Write("Entre o valor de Depósito inicial: ");
                double valorinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                co.Depositar(valorinicial);
            }

            Console.WriteLine(co);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            co.Depositar(deposito);
            Console.WriteLine(co);

            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            co.Sacar(saque);
            Console.WriteLine(co);



        }
    }
}
