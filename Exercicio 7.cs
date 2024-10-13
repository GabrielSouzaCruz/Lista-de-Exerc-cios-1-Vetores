using System;
using Arrays;

namespace Exercicio7
{
    class Exercicio_7
    {
        static void Main()
        {
            int n;

            Console.Write("Entre com o número de Elementos: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] meuVetor = new int[n];
            BibliotecaArray.geraVetor(meuVetor);
            Console.WriteLine("Primeiro Vetor igual à: ");
            BibliotecaArray.mostraVetor(meuVetor);
            Console.WriteLine();

            int[] segundoVetor = new int[n];
            BibliotecaArray.geraVetor(segundoVetor);
            Console.WriteLine("Segundo Vetor igual à: ");
            BibliotecaArray.mostraVetor(segundoVetor);
            Console.WriteLine();

            int[] resultVetor = new int[n];

            for (int i = 0; i < meuVetor.Length; i++)
            {
                resultVetor[i] = meuVetor[i] * segundoVetor[i];
            }
            Console.WriteLine("A multiplicação dos elementos de mesmo índice igual à: ");
            BibliotecaArray.mostraVetor(resultVetor);

            Console.ReadKey();
        }
    }
}
