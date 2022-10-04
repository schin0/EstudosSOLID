using System;

namespace EstudosSOLID.Modulo2.Composicao
{
    class Departamento : IDisposable
    {
        private Escola escola;
        private string nome;

        /*
        Usamos um construtor interno para limitar como ele pode ser criado
        Já que um departamento não terá sentido por si só     
         */
        internal Departamento(Escola escola, string nome)
        {
            this.escola = escola;
            this.nome = nome;
        }

        // Serve para destruir a instância
        public void Dispose() { }
    }
}
