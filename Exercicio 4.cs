using System;
using Arrays;

namespace Exercicio4
{
    class Execicio_4
    {
        static void Main()
        {
            int n;

            Console.Write("Entre com o número de Elementos: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] meuVetor = new int[n];

            BibliotecaArray.geraVetor(meuVetor);

            Console.WriteLine("O elemento digitados foram: ");
            BibliotecaArray.mostraVetor(meuVetor);

            Console.WriteLine();

            BibliotecaArray.imparesElemento(meuVetor);

            Console.ReadKey();
        }
    }
}