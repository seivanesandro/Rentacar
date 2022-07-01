using System;

namespace Rentacar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um programa em C# para uma empresa de aluguer de automóveis, que imprima o montante devido por cada cliente.
                O montante devido depende dos quilómetros efetuados, do número de dias que durou o aluguer e do tipo de carro alugado.
                Os Volkswagen custam 30€ por dia e 1,20€ por quilómetro. 
                Os Toyota custam 35€ por dia e 1,50€ por quilómetro.
                Os Mercedes custam 60€ por dia e 2,50€ por quilómetro. 
                Os primeiros 75 quilómetros são gratuitos, independentemente do tipo de carro alugado.
             */

            String strApelido, strNome;
            int intCarro, intDias;
            double doubleKms = 0, doubleIlliquido = 0, doubleIVA = 0, doubleTotal = 0;

            Console.Write("Indique o seu Nome: ");
            strNome = Console.ReadLine();

            Console.Write("Indique o seu Apelido: ");
            strApelido = Console.ReadLine();

            do
            {
                Console.Write("Indique o tipo de carro que deseja (1=Volkswagen, 2=Toyota, 3=Mercedes):");
                intCarro = int.Parse(Console.ReadLine());
            } while (intCarro!=1 && intCarro!=2 && intCarro!=3);
            


            Console.Write("Indique os Km's efectuados: ");
            doubleKms = double.Parse(Console.ReadLine());

            Console.Write("Qual o Nr de dias de aluger: ");
            intDias = int.Parse(Console.ReadLine());



            Console.WriteLine("\n");
            Console.WriteLine("Apelido: " + strApelido);
            Console.WriteLine("Nome: " + strNome);

            if (intCarro == 1)
            {
                doubleIlliquido = ((30 * intDias) + (1.20 * (doubleKms - 75)));
                doubleIVA = (doubleIlliquido * 0.23);
                doubleTotal = (doubleIlliquido + doubleIVA);
                Console.WriteLine("Tipo de carro: 1 - Volkswagen");

            }
            else if (intCarro == 2)
            {
                doubleIlliquido = ((35 * intDias) + (1.50 * (doubleKms - 75)));
                doubleIVA = (doubleIlliquido * 0.23);
                doubleTotal = (doubleIlliquido + doubleIVA);
                Console.WriteLine("Tipo de carro: 2 - Toyota");
            }
            else if (intCarro == 3)
            {
                doubleIlliquido = ((60 * intDias) + (2.50 * (doubleKms - 75)));
                doubleIVA = (doubleIlliquido * 0.23);
                doubleTotal = (doubleIlliquido + doubleIVA);
                Console.WriteLine("Tipo de carro: 3 - Mercedes");
            }

            Console.WriteLine("Kms Efetuados:  " + doubleKms + " km");
            Console.WriteLine("Nº Dias de Aluguer: " + intDias + " dias");
            Console.WriteLine("Total Ilíquido: {0:0.00}" , doubleIlliquido + " euros");
            Console.WriteLine("Total Iva(23%): {0:0.00}", doubleIVA + " euros");
            Console.WriteLine("Total Final: {0:0.0}" , doubleTotal + " euros");
            Console.ReadKey();
        }
    }
}
