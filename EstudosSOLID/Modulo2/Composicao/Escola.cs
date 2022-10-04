using System;
using System.Collections.Generic;

namespace EstudosSOLID.Modulo2.Composicao
{
    class Escola : IDisposable
    {
        public string Nome { get; set; }
        private IList<Departamento> departamentos = new List<Departamento>();

        // Somente Escola poderá criar Departamentos
        public void AdicionarDepartamento(string nome)
            => departamentos.Add(new Departamento(this, nome));

        public void Dispose()
        {
            foreach (var departamento in departamentos)
                departamento.Dispose();
        }
    }
}
