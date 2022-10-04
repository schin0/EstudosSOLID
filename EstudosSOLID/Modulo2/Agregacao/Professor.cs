using System;

namespace EstudosSOLID.Modulo2.Agregacao
{
    class Professor : IDisposable
    {
        public string Nome { get; set; }

        public void Dispose() { }
    }
}
