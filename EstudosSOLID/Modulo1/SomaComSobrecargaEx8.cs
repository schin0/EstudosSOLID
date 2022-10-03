using System;

namespace EstudosSOLID.Modulo1
{
    public class SomaComSobrecargaEx8
    {
        public void Somar() => Console.WriteLine("Nenhum valor informado");

        public int Somar(int num1, int num2) => num1 + num2;
        
        public double Somar(double num1, double num2) => num1 + num2;

        public double Somar(double num1, int num2) =>  num1 + num2;

        public double Somar(int num1, double num2) => num1 + num2;
    }
}
