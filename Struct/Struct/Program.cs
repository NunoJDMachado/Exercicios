using Struct;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        Point p;
        p.X = 10;
        p.Y = 20;

        Console.WriteLine(p);

        p = new Point();    //instanciei um objeto, mas ainda não lhe dei valores
        Console.WriteLine(p);   //entao imprime 0 que é o valor padrão (ver ppt)

        //double X = null;    //structs não podem ser nulos, então dá erro.
        double? X = null;   //assim já pode

        double? Y = 10.0;   //podia ser sem ?, mas para ver o metodo getvalue em baixo tem de ter

        Console.WriteLine(X.GetValueOrDefault());   //ou dá o valor default (quando é nulo, como no caso do X)
                                                    //imprime 0 porque o valor default de um double é 0
        Console.WriteLine(Y.GetValueOrDefault());   //ou o valor atribuido (Y)

        Console.WriteLine(X.HasValue);
        Console.WriteLine(Y.HasValue);

        Console.WriteLine();
        Console.WriteLine();

        if (X.HasValue)
        {
            Console.WriteLine("O valor de X é " + X.Value);
        }
        else
        {
            Console.WriteLine("X é nulo");
        }

        if (Y.HasValue)
        {
            Console.WriteLine("O valor de Y é " + Y.Value);
        }
        else
        {
            Console.WriteLine("Y é nulo");
        }


    }
}