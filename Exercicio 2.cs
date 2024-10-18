using System;
using Arrays;

namespace Exercicio2
{
    class Execicio_2
    {
        static void Main()
        {
            int n;

            Console.Write("Entre com o número de Elementos: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double[] meuVetor = new double[n];

            BibliotecaArray.geraVetor(meuVetor);

            Console.WriteLine("O elemento digitados foram: ");
            BibliotecaArray.mostraVetor(meuVetor);

            Console.WriteLine();

            BibliotecaArray.maiorElemento(meuVetor);

            Console.ReadKey();
        }
    }
}


