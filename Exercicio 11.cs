using System;
using Arrays;

namespace Exercicio11
{
    class Exercicio_11
    {
        static void Main()
        {
            string frase;

            Console.Write("Entre com Uma Frase Codificada: ");
            frase = Console.ReadLine();

            for (int i = 1; i < frase.Length-1; i++)
            {
               
                if (frase[i] != 'p' && frase[i] != 'p') 
                {
                    Console.Write(frase[i]);
                }else if (frase[i-1] == 'p' && frase[i+1] == 'p')
                {
                    Console.Write(frase[i]);
                }
            }
            Console.Write(frase[frase.Length - 1]);
        }
    }
}
