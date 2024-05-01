using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string NameAluno = Console.ReadLine();
        Console.WriteLine("Digite a primeira nota do aluno {0}", NameAluno);
        double N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a segunda nota do aluno {0}", NameAluno);
        double N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (N1 + N2) / 2;

        System.Console.WriteLine("====================================================");
        System.Console.WriteLine("                 APROVEITAMENTO!!!");
        System.Console.WriteLine("====================================================");
    
        if ( media >= 7 )
        {
            System.Console.WriteLine("Seu aproveitamento foi BOM!!!");
            System.Console.WriteLine("Sua media é: " + media);
        }
        else if ( media < 7)
        {
            System.Console.WriteLine("Seu aproveitamento foi RUIM!!!");
            System.Console.WriteLine("Sua media é: " + media);
        }
    
    
    
    
    }
}