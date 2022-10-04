namespace EstudosSOLID.Modulo2.ClassesAbstratas
{
    class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public override void CalcularArea() => Area = Lado * Lado;

        public override void CalcularPerimetro() => Perimetro = 4 * Lado;

    }
}
