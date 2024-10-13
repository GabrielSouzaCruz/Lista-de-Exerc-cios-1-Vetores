using System;
using Arrays;

namespace Exercicio8
{
    class Exercicio_8
    {
        static void Main()
        {
            int n;

            Console.Write("Entre com o número de Elementos: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] meuVetor = new int[n];
            BibliotecaArray.geraVetor(meuVetor);

            Console.WriteLine("Vetor gerado igual à: ");
            BibliotecaArray.mostraVetor(meuVetor);
            Console.WriteLine();

            Console.WriteLine("Vetor Inverso: ");

            for (int i = meuVetor.Length-1; i >= 0; i--)
            {
                Console.Write($" {meuVetor[i]} |");
            }
        }
    }
}
    

