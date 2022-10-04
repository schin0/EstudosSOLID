namespace EstudosSOLID.Modulo2.Heranca
{
    class ContaCorrente : Conta
    {
        public double Limite { get; set; }

        public double DescontarJuros(double valorDesconto) => Saldo - valorDesconto;

    }
}
