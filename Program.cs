using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {








            const double g = 9.80665;

            double anguloEmGraus;
            double velocidade;
            double anguloRadiano;
            double alcance;
            double altura;

            Console.WriteLine();
            Console.WriteLine("---- Projetil ----");
            Console.WriteLine("Cálculo do lançamento de um projetil.");
            Console.WriteLine();

            Console.WriteLine("Dê a Velocidade em m/s:");
            velocidade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dê o Ângulo em graus:");
            anguloEmGraus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            anguloRadiano = anguloEmGraus * (Math.PI / 180);

            alcance = Math.Pow(velocidade, 2) * Math.Sin(2 * anguloRadiano) / g;

            altura = Math.Pow((velocidade * Math.Sin(anguloRadiano)), 2) / (2 * g);

            Console.WriteLine($"Alcance: {alcance:N2} m");
            Console.WriteLine($"Altura: {altura:N2} m");











        }
    }
}
