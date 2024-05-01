using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        float Vcar, Multa;
        
        Console.WriteLine("Qual a velocidade do carro no momento (em Km/h): ");
        Vcar = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (Vcar > 80)
        {
            Multa = (Vcar - 80) * 5;
            System.Console.WriteLine("============== A L E R T A !!! =================");
            System.Console.WriteLine("Velocidade acima do limite!! Você foi Multado !!");
            System.Console.WriteLine("Multa no valor de: R${0}", Multa);
            System.Console.WriteLine("================================================");

        }
        else if (Vcar <= 80)
            System.Console.WriteLine("Dentro dos padrões");
    }
}