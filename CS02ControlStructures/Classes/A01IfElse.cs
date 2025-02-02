namespace CS02ControlStructures.Classes;

public static class A01IfElse
{
    public static void Run()
    {
        Console.WriteLine("==> IF / ELSE IF / ELSE");
        
        Console.WriteLine("Cliente especial? (S/N)");
        var clienteEspecial = Console.ReadLine()?.ToUpper();

        if (clienteEspecial == "S")
            Console.WriteLine("Cliente especial: Desconto de 10%");
        else
            Console.WriteLine("Cliente normal.");

        Console.WriteLine("Digite o valor de X: ");
        var xValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor de Y: ");
        var yValue = Convert.ToInt32(Console.ReadLine());

        if (xValue < yValue)
        {
            Console.WriteLine($"{xValue} é menor que {yValue}");
        }
        else if (xValue > yValue)
        {
            Console.WriteLine($"{xValue} é maior que {yValue}");
        }
        else
        {
            Console.WriteLine($"{xValue} é igual a {yValue}");
        }

        Console.WriteLine("Fim do processamento");
    }
}