using System;

namespace EstudosSOLID.Modulo2.Heranca
{
    class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; set; }

        public double CreditarJuros(double valorJuros) => Saldo + valorJuros;

    }
}
