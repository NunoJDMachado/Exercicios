using Exercício_2_vetores;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira o número de produtos :");
        int N = int.Parse(Console.ReadLine());

        Produto[] vet = new Produto[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Qual o produto?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o preço do produto?");
            double preco = double.Parse(Console.ReadLine());
            vet[i] = new Produto { Nome = nome, Preco = preco };

            double soma = 0.0;
            for (i = 0; i < N; i++)
            {
                soma = soma + vet[i].Preco;
            }

            double media = soma / N;

            Console.WriteLine("A média é " + media);
        }

    }

}