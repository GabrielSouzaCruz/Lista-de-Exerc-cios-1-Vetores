using System;
using Arrays;

namespace Exercicio12
{
    internal class Exercicio_12
    { 
        static void Main()
        {
            Console.WriteLine("Digite as cinco notas, uma por vez:");
            float[] notas = new float[5];

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = float.Parse(Console.ReadLine());
            }

            float maior = notas[0];
            float menor = notas[0];

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maior)
                {
                    maior = notas[i];
                }

                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            float somaTotal = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                somaTotal += notas[i];
            }

            float notaFinal = somaTotal - maior - menor;

            Console.WriteLine($"A nota final da escola é: {notaFinal:F1}");
        }
    }
}

