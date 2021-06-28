using System;
using System.Globalization;


namespace Setimo_POO_Classe {
    class Program {
        static void Main(string[] args) {
            Aluno Aln = new Aluno();

            Console.Write("Nome do Aluno: ");
            Aln.nome =  Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            Aln.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aln.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aln.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = {0}", Aln.NotaFinal());
            Console.WriteLine(Aln.Resultado());

        }
    }
}
