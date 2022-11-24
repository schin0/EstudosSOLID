using System;

namespace EstudosSOLID.Modulo2.Sealed
{
    public class OverrideXSealed : Sealed
    {
        // Não é possível pois definimos OverrideUm() como sealed
        //protected override void OverrideUm()
        //{
        //    Console.WriteLine("override 1");
        //}

        protected override void OverrideDois()
        {
            Console.WriteLine("override 2");
        }
    }
}
