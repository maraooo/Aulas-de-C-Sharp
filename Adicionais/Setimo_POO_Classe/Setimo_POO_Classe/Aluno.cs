using System;
using System.Globalization;

namespace Setimo_POO_Classe {
    class Aluno {
        public string nome;
        public double nota1, nota2, nota3;

        public double NotaFinal() {
            return nota1 + nota2 + nota3;
        }

        public string Resultado() {
            if (NotaFinal() >= 60) {
                return "APROVADO";
            }
            else {
                double faltante = 60 - NotaFinal();
                return "REPROVADO, FALTARAM" + faltante + "PONTOS";
            }
        }
    }
}
