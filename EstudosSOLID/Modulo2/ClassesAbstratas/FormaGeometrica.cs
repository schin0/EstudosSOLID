using EstudosSOLID.Modulo2.ClassesAbstratas.Enum;

namespace EstudosSOLID.Modulo2.ClassesAbstratas
{
    /* 

    Ao herdarmos de uma classe abstrata, obrigamos as classes a implementar os métodos
    presentes na classe abstrata.
    
     */
    abstract class FormaGeometrica
    {
        public CorEnum Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        public string Descrever() => "Eu sou um exemplo de classe abstrata";

    }
}
