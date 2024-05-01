using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Favor informar o seu nome: ");
        string NameCliente = Console.ReadLine()!;
        System.Console.WriteLine("Informe o sexo: [M/F]");
        string Sexo = Console.ReadLine()!;
        System.Console.WriteLine("Informe o valor total da compra: ");
        double ValorConta = double.Parse(Console.ReadLine()!);

        double ValorTotal;

        if (Sexo == "M")
        {
            ValorTotal = ValorConta - (ValorConta * 0.05);
            System.Console.WriteLine("O Valor total da compra ficou: R${0}", ValorTotal.ToString("F2", CultureInfo.InvariantCulture)); 
        }
        else if (Sexo == "F")
        {
            ValorTotal = ValorConta - (ValorConta * 0.13);
            System.Console.WriteLine("O Valor total da compra ficou: R${0}", ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
        



        
    }
}