using System;



namespace Arrays
{
    public class BibliotecaArray
    {
       public static void leiaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)//lendo dados para vetor
            {
                Console.Write($"[{i}]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)//mostrando os dados do vetor
            {
                Console.Write($" {vetor[i]} |");
            }
        }
       public static void geraVetor(int[] vetor)
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)//gerando vetor
            {
                vetor[i] = random.Next(1, 100);
            }
        }
       public static int somaVetor(int[] vetor)
        {
            int soma = 0;

            for (int j = 0; j < vetor.Length; j++)
            {
                soma += vetor[j];
            }

            Console.WriteLine($"\nA soma dos Elementos é: {soma}");

            return vetor[0];
        }

        public static void imparesElemento(int[] vetor)
        {
            int impar = 0;
            for (int j = 0; j < vetor.Length; j++)
            {
               if(vetor[j] % 2 != 0)
                {
                    impar++;
                }
            }

            Console.WriteLine($"\n O numero de Elementos impares é: {impar}");
        }

        //Função Para receber Doubles

        public static void leiaVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)//lendo dados para vetor
            {
                Console.Write($"[{i}]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void mostraVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)//mostrando os dados do vetor
            {
                Console.Write($" {vetor[i]:F2} |");
            }
        }
        public static void geraVetor(double[] vetor)
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)//gerando vetor
            {
                vetor[i] = random.Next(1, 100) + random.NextDouble();
            }
        }
        public static double somaVetor(double[] vetor)
        {
            double soma = 0;

            for (int j = 0; j < vetor.Length; j++)
            {
                soma += vetor[j];
            }

            Console.WriteLine($"\nA soma dos Elementos é: {soma:F2}");

            return vetor[0];
        }

        public static void maiorElemento(double[] vetor)
        { 
            double maior = double.MinValue;

            for(int j = 0;j < vetor.Length;j++)
            {
                if (vetor[j] > maior)
                {
                    maior = vetor[j];
                }

            }

            Console.WriteLine($"\nO Maior dos Elementos é: {maior:F2}");
        }

        public static void menorElemento(double[] vetor)
        {
            double menor = double.MaxValue;

            for (int j = 0; j < vetor.Length; j++)
            {
                if (vetor[j] < menor)
                {
                    menor = vetor[j];
                }

            }

            Console.WriteLine($"\nO Menor dos Elementos é: {menor:F2}");
        }


    }

}
