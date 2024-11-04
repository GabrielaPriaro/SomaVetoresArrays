//Utilizando Arrays:
//Problema "soma_vetores"
//Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um
//terceiro vetor C onde cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima
//o vetor C gerado. 

namespace SomaVetoresArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;

            Console.Write("Quantos valores vai ter cada vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] vetA = new int[n];
            int[] vetB = new int[n];
            int[] vetC = new int[n];

            Console.WriteLine("Digite os valores do vetor A:");
            for (int i = 0; i < n; i++)
            {
                vetA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os valores do vetor B:");
            for (int i = 0; i < n; i++)
            {
                vetB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("VETOR RESULTANTE:");
            for (int i = 0; i < n; i++)
            {
                vetC[i] = vetA[i] + vetB[i];
                Console.WriteLine(vetC[i]);
            }
        }
    }
}
