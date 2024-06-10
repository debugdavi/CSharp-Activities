
using System;
using System.Globalization;
namespace bancoPessoas {
    internal class Conta {
        public string NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string nc, string titular) {
            NumConta = nc;
            Titular = titular;
            Saldo = 0;
        }

        public Conta(string nc, string titular, double saldo) : this(nc, titular) {
            Saldo = saldo;
        }

        public void Deposito(double dep) {
            Saldo += dep;
        }

        public void Saque(double saq) {
            Saldo = Saldo - saq - 5;
        }


        public override string ToString() {
            return $"Conta {NumConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }



    }
}
