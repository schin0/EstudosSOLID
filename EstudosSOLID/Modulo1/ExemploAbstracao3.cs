using System;

namespace EstudosSOLID.Modulo1
{
    class ExemploAbstracao3
    {
    }

    class ComputadorParaEstudo
    {
        public double Armazenamento { get; set; }
        public double Preco { get; set; }
        public bool EsteticaAgradavel { get; set; }

        public static void NavegarNaInternet()
        {
            Console.WriteLine("Navegando na web");
        }
    }

    class ComputadorParaTrabalho
    {
        public double Armazenamento { get; set; }
        public double MemoriaRAM { get; set; }
        public string Processador { get; set; }
        public int Nucleos { get; set; }

        public static void NavegarEmSistemasComRapidez()
        {
            Console.WriteLine("É rápido navegando.");
        }

        public static void ProcessarVariosAplicativosAoMesmoTempo()
        {
            Console.WriteLine("App 1 rodando...");
            Console.WriteLine("App 2 rodando...");
            Console.WriteLine("App 3 rodando...");
        }
    }
}
