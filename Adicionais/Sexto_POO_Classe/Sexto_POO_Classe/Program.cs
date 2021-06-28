using System;
using System.Globalization;

namespace Sexto_POO_Classe {
    class Program {
        static void Main(string[] args) {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            p1.nome = Console.ReadLine();
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:");
            p2.nome = Console.ReadLine();
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (p1.salario + p2.salario) / 2;

            Console.WriteLine("Salário Médio: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
