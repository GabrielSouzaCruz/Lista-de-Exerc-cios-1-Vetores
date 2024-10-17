using System;
using Arrays;

namespace Exercicio9
{
    class Exercicio_9
    {
        static void Main()
        {
            int n, num;
            int cont = 0;

            Console.Write("Entre com o número de Elementos: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();

            int[] meuVetor = new int[n];
            BibliotecaArray.geraVetor(meuVetor);

            Console.Write("Entre com um Valor: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Vetor gerado igual à: ");
            BibliotecaArray.mostraVetor(meuVetor);
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < meuVetor.Length; i++)
            {
                if(num == meuVetor[i])
                {
                    
                    cont++;
                }
            }

            Console.WriteLine($"O Valor digitado apareceu {cont} vezes");
            Console.ReadKey();

        }
    }
}
