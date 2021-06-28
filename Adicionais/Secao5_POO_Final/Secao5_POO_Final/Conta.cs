using System.Globalization;

namespace Secao5_POO_Final {
    class Conta {
        public int NumConta { get; private set; }
        public string NomeConta { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numconta, string nome){
            NumConta = numconta;
            NomeConta = nome;
            Saldo = 0;
        }

        public void Depositar(double deposito) {
            Saldo += deposito;
        }

        public void Sacar(double saque) {
            Saldo -= saque + 5.00;
        }

        public override string ToString() {
            return "Conta: " + NumConta + ", Titular: " + NomeConta + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
