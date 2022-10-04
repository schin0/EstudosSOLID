using System;

namespace EstudosSOLID.Modulo2
{
    public class PessoaUML
    {
        public PessoaUML() { }

        public PessoaUML(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        private DateTime dataNascimento = new DateTime(2000, 10, 2);

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public void IdentificarPessoa()
            => Console.WriteLine($"{Nome} - {Idade} - {Sexo}");

    }
}
