namespace EstudosSOLID.Modulo1
{
    public class ClasseEObjetoEx1
    {
        /* 
         * 
        Classe: serve como um "molde" para criação de objetos, contendo os atributos
        e comportamentos que definem os objetos.

        Objeto: é uma instância de uma classe, onde temos as propriedades e métodos definidos
        na classe.

        Classes são tipos e Objetos são instâncias.

         */
    }

    //exemplo Classe:
    // modificadorDeAcesso class NomeDaClasse { campos e propriedades }
    public class ClasseExemplo
    {
        public int PropriedadeExemplo { get; set; }

        // Construtor:
        public ClasseExemplo()
        {
            PropriedadeExemplo = 1;
        }
    }

    //exemplo Objeto:
    public class Exemplo
    {
        public void ExemploObj()
        {
            var exemploObj = new ClasseExemplo();
            System.Console.WriteLine("Objeto: " + exemploObj);
        }
    }
}
