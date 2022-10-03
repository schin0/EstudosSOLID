using System;

namespace EstudosSOLID.Modulo1
{
    class HerancaEx10
    {
        /*

        Com a herança, conseguimos copiar/herdar todas as propriedades, métodos e
        atributos de uma classe para outra (classe filha).

        Classe Geral: Documento
        Classe específica 1: Cliente
        Classe específica 2: Funcionário

        */
    }

    // Exemplos:
    public class Documento
    {
        public string TipoDeDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime DataExpedicao { get; set; }
    }

    public class Cliente : Documento
    {
        public string NomeCliente { get; set; }
    }

    public class Funcionario : Documento
    {
        public string NomeFuncionario { get; set; }
        public string CarteiraDeTrabalho { get; set; }
    }
}
