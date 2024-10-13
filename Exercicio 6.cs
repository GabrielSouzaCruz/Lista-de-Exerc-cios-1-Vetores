using System;
using Arrays;

namespace Exercicio6
{
    class Exercicio_6
    {
        static void Main()
        {
            int n, num, igual = 0;

            Console.Write("Entre com o número de Elementos: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] meuVetor = new int[n];

            BibliotecaArray.geraVetor(meuVetor);

            do{
            Console.Write("Informe o número: ");
            num = int.Parse(Console.ReadLine());

                for (int i = 0; i < meuVetor.Length; i++)
            {
                if (num == meuVetor[i])
                {
                    igual = meuVetor[i];
                }
            }
                if (num == igual)
                {
                    Console.WriteLine("o número digitado está no vetor");
                }
                else
                {
                    Console.WriteLine("o número digitado não está no vetor");
                }

            } while(num != igual);
        }
    }
}
