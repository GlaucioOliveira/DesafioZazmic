using DesafioZazmic.Util.Algorithm;
using DesafioZazmic.Util.ExtensionMethods;
using System;

namespace DesafioZazmic
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Descobrir possibilidades de subir uma escada de 1 ou 2 degraus por vez\n");

                Console.Write("Quantidade de Degraus: ");

                int quantidadeDegraus = Console.ReadLine().PegaInteiro();

                if (validaQuantidadeDegraus(quantidadeDegraus))
                {
                    NStairAlgorithm.listarPossibilidadesSubida(quantidadeDegraus);
                }

                Console.ReadKey(intercept: true);
            }
        }

        static bool validaQuantidadeDegraus(int degraus)
        {
            if (degraus <= 0 || degraus > 6)
            {
                Console.WriteLine("\nERRO: Digite um número positivo e menor que 6.\n");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
