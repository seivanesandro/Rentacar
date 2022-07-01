using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipocarro = 0;
            double diasaluguer = 0, quilómetros = 0, totaliliq = 0, totaliva = 0, totalfinal = 0;
            String nome, apelido;

            Console.Write("Indique o seu apelido: ");
            apelido = Console.ReadLine();

            Console.Write("Indique o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Que tipo de carro utilizou? (1-Volkswagem, 2-Toyota, 3-Mercedes) ");
            tipocarro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos Quilómetros efectuou? ");
            quilómetros = double.Parse(Console.ReadLine());

            Console.Write("Alugou o carro durante quantos dias? ");
            diasaluguer = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Apelido: " + apelido);
            Console.WriteLine("Nome: " + apelido);

            if (tipocarro == 1)
            {
                totaliliq = ((30 * diasaluguer) + (1.20 * quilómetros));
                totaliva = (totaliliq * 0.23);
                totalfinal = (totaliliq + totaliva);
                Console.WriteLine("Tipo de Carro: " + tipocarro + " - Volkswagem");
            }

            else if (tipocarro == 2)
            {
                totaliliq = ((30 * diasaluguer) + (1.20 * quilómetros));
                totaliva = (totaliliq * 0.23);
                totalfinal = (totaliliq + totaliva);
                Console.WriteLine("Tipo de Carro: " + tipocarro + " - Toyota");
            }

            else if (tipocarro == 3)
            {
                totaliliq = ((30 * diasaluguer) + (1.20 * quilómetros));
                totaliva = (totaliliq * 0.23);
                totalfinal = (totaliliq + totaliva);
                Console.WriteLine("Tipo de Carro: " + tipocarro + " - Mercedes");
            }

            else
                Console.WriteLine("Introduza um número entre 1 e 3");

            Console.WriteLine("Kms Efetuados: " + quilómetros);
            Console.WriteLine("Nº Dias de Aluguer: " + diasaluguer);
            Console.WriteLine("Total Ilíquido: " + totaliliq);
            Console.WriteLine("IVA (23%): " + totaliva);
            Console.WriteLine("Total Final: " + totalfinal);

            Console.ReadKey(); Console.WriteLine("Hello World!");
        }
    }
}
