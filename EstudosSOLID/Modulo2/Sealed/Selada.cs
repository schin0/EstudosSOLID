namespace EstudosSOLID.Modulo2.Sealed
{
    /*
      Classes seladas não podem ser herdadas em outras, por isso não conseguimos
      usar uma como base

      São consideradas o oposto das classes abstratas
     */

    public sealed class Selada
    {
        private static int Somar(int num1, int num2)
        {
            // Podemos criar uma instância de classes sealed normalmente:
            var soma = new CalculaSomaSelada();
            return soma.Somar(num1, num2);
        }
    }
}
