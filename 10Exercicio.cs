using System;
using Arrays;

namespace Exercicio10
{
    class Exercicio_10
    {
        public static void geraVetor(int[] vetor)
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)//gerando vetor
            {
                vetor[i] = random.Next(1, 6);
            }
        }
        static void Main()
        {
            int n;

            Console.WriteLine("O número de Faces é Igual a 6");

            Console.Write("Digite o Numero de Lançamentos de Dado: ");
            n = int.Parse(Console.ReadLine());

            int[] meuVetor = new int[n];
            geraVetor(meuVetor);

            int[] contagem = new int[n];

            Console.WriteLine("Resultado dos Lançamentos foram: ");
            BibliotecaArray.mostraVetor(meuVetor);
            Console.WriteLine();
            Console.WriteLine();


            // Contar as ocorrências de cada face
            foreach (int resultado in meuVetor)
            {
                contagem[resultado - 1]++;
            }

            // Exibir os resultados
            for (int i = 0; i < contagem.Length; i++)
            {
                Console.WriteLine($"Face {i + 1}: {contagem[i]} ocorrência(s)");
            }
        }

    }
}

