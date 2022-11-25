using System;

namespace EstudosSOLID.Modulo2.Sealed
{
    public class Sealed : Override
    {
        // Para sealed e override, iremos sobrescrever nessa classe atual,
        // porém, na classe OverrideXSealed, por exemplo, que herda essa que estamos,
        // não poderemos sobrescrever o método OverrideUm()
        sealed protected override void OverrideUm()
        {
            Console.WriteLine("override 1");
        }

        protected override void OverrideDois()
        {
            Console.WriteLine("override 2");
        }
    }
}
