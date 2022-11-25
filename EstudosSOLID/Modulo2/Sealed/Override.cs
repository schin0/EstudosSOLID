using System;

namespace EstudosSOLID.Modulo2.Sealed
{
    public class Override
    {
        // Lembrando que propriedade virtual pode ser sobrescrita nas classes derivadas
        protected virtual void OverrideUm()
        {
            Console.WriteLine("override 1");
        }
        
        protected virtual void OverrideDois()
        {
            Console.WriteLine("override 2");
        }
    }
}
