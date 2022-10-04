using System;

namespace EstudosSOLID.Modulo2.ComposicaoXHeranca
{
    class Homem
    {
        Animal gato = new Animal();

        ComportamentoAndar comportamentoAndar = new ComportamentoAndar();

        public void Cumprimentar() => Console.WriteLine("aoba");
    }
}
