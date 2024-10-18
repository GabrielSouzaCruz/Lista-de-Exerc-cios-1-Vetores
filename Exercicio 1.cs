using System;
using System.Runtime.Serialization;
using Arrays;
namespace Exercicio1
{
    class Exercicio_1
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

            BibliotecaArray.somaVetor(meuVetor);

            Console.ReadKey();
        }
    }
}

