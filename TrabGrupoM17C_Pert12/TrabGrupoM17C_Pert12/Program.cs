using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabGrupoM17C_Pert12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 5, 11, 1, 23, 5, 2, 9, 1, 8, 24 };

            int indiceMaiorValor = 0;
            int maiorValor = numeros[0];


            for (int i = 1; i < numeros.Length; i++)
            {

                if (numeros[i] > maiorValor)
                {
                    maiorValor = numeros[i];
                    indiceMaiorValor = i;

                }
            }

            
            Console.WriteLine($"O maior valor é {maiorValor} e encontra-se no índice {indiceMaiorValor}.");
            Console.ReadLine();
        }
    }

}

    