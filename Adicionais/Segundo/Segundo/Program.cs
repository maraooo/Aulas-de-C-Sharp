using System;
using System.Globalization;

namespace Segundo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome Completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] matriz = Console.ReadLine().Split(" ");
            string ultimoNome = matriz[0];
            string idade = matriz[1];
            string altura = matriz[2];



            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
