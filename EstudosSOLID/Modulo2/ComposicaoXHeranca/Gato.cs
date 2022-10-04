using System;

namespace EstudosSOLID.Modulo2.ComposicaoXHeranca
{
    class Gato
    {
        Animal gato = new Animal();

        ComportamentoAndar comportamentoAndar = new ComportamentoAndar();

        public void Miar() => Console.WriteLine("miau");
    }
}
