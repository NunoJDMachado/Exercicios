internal class Program
{
    private static void Main(string[] args)
    {

        /*Console.Write("Insira o número de pessoas: ");
        int N = int.Parse(Console.ReadLine());
        
        double[] alturas = new double[N];   //criação e instanciação do vetor
        
        Console.Write("Insira a altura da primeira pessoa: ");
        alturas[0] = double.Parse((Console.ReadLine()));
        Console.Write("Insira a altura da segunda pessoa: ");
        alturas[1] = double.Parse((Console.ReadLine()));
        Console.Write("Insira a altura da terceira pessoa: ");
        alturas[2] = double.Parse((Console.ReadLine()));

        Console.WriteLine("A média das alturas é " + ((alturas[0] + alturas[1] + alturas[2]) / 3));*/

        Console.Write("Insira o número de pessoas: ");
        int N = int.Parse(Console.ReadLine());

        double[] alturas = new double[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite um altura: ");
            alturas[i] = double.Parse((Console.ReadLine()));
        }

        double soma = 0;

        for (int i = 0;i < N; i++)
        {
            soma = soma + alturas[i];
        }

        double media = soma / N;

        Console.WriteLine("A média das alturas é: " + media);
    }
}