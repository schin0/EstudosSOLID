using System;
using System.Collections.Generic;

namespace EstudosSOLID.Modulo2.Agregacao
{
    class Departamento : IDisposable
    {
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; }

        public void Dispose() { }
    }
}
