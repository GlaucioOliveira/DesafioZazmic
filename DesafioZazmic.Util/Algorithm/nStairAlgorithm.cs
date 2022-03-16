using System;
using System.Collections.Generic;

namespace DesafioZazmic.Util.Algorithm
{
    public static class NStairAlgorithm
    {
        /// <summary>
        /// Exibir todas as possibilidades para subir uma escada com a quantidade de degraus especificada.
        /// </summary>
        /// <param name="degraus">Quantidade de Degraus da Escada</param>
        public static List<string> listarPossibilidadesSubida(int degraus)
        {
            String[] textoSaidaPossibilidade = new String[degraus + 1];
            List<string> ListaDePossibilidades = new List<string>();

            listarPossibilidadesSubidaInternal(textoSaidaPossibilidade, ListaDePossibilidades, 0, degraus);

            return ListaDePossibilidades;
        }


        /// <summary>
        /// Exibir todas as possibilidades para subir uma escada com a quantidade de degraus especificada
        /// <para>Referência: </para>
        /// <a href="https://www.geeksforgeeks.org/count-ways-reach-nth-stair/">Count ways to reach the n’th stair (geeksforgeeks)</a>
        /// <para></para>
        /// <a href="https://crazycoderzz.wordpress.com/implement-a-function-that-prints-all-the-ways-to-climb-up-n-step-stairs/">Implement a function that prints all the ways to climb up N step stairs (crazycoderzz Blog)</a>
        /// </summary>
        /// <param name="textoSaidaPossibilidade">Buffer de string para imprimir as possibilidades</param>
        /// <param name="indice">'indice' é onde será colocado '1' e '2'.</param>
        /// <param name="degraus">Quantidade de degraus</param>
        private static void listarPossibilidadesSubidaInternal(string[] textoSaidaPossibilidade, List<string> ListaDePossibilidades, int indice, int degraus)
        {
            if (degraus < 0) return;

            if (degraus == 0)
            {
                textoSaidaPossibilidade[indice] = "";
                string textoSaida = String.Join(null, textoSaidaPossibilidade);

                Console.WriteLine(textoSaida);
                
                ListaDePossibilidades.Add(textoSaida);

                return;
            }
            
            textoSaidaPossibilidade[indice] = "1"; 
            listarPossibilidadesSubidaInternal(textoSaidaPossibilidade, ListaDePossibilidades, indice + 1, degraus - 1); // Adicionar ou diminuir por 1 

            textoSaidaPossibilidade[indice] = "2";
            listarPossibilidadesSubidaInternal(textoSaidaPossibilidade, ListaDePossibilidades, indice + 1, degraus - 2);  // Ou Adicionar ou diminuir por 2
        }
    }
}
