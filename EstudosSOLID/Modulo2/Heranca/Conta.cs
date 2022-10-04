namespace EstudosSOLID.Modulo2
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public double Sacar(double valorSaque) => Saldo - valorSaque;

        public double Depositar(double valorDeposito) => Saldo + valorDeposito;

    }
}
