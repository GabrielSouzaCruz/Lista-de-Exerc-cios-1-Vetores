using System;
using Arrays;


namespace Exercicio5
{
    class Exercicio_5
    { 
        static void Main()
        {
            char[] dna = new char[50];
            char[] complementar = new char[dna.Length];
            BibliotecaArray.geraElemento(dna);
            

            for (int i = 0; i < dna.Length; i++)
            {
                switch (dna[i])
                {
                    case 'A':
                        complementar[i] = 'T';
                        break;
                    case 'T':
                        complementar[i] = 'A';
                        break;
                    case 'C':
                        complementar[i] = 'G';
                        break;
                    case 'G':
                        complementar[i] = 'C';
                        break;
                    default:
                        throw new Exception("Base desconhecida no DNA");
                }
            }

            Console.WriteLine("DNA Original: " + new string(dna));
            Console.WriteLine("DNA Complementar: " + new string(complementar));

            Console.ReadKey(); 
        }
    }
}
