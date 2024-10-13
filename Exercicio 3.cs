using System;
using Arrays;

namespace Exercicio3
{
    class Execicio_3
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

            BibliotecaArray.menorElemento(meuVetor);

            Console.ReadKey();
        }
    }
}