namespace CS02ControlStructures.Classes;

public static class A02SwitchCase
{
    public static void Run()
    {
        Console.WriteLine("==> SWITCH CASE");
        Console.WriteLine("Digite um número relacionado a um dia da semana: ");
        var diaDaSemana = Convert.ToInt32(Console.ReadLine());

        switch (diaDaSemana)
        {
            case 1:
                Console.WriteLine("Segunda-feira");
                break;
            case 2:
                Console.WriteLine("Terça-feira");
                break;
            case 3:
                Console.WriteLine("Quarta-feira");
                break;
            case 4:
                Console.WriteLine("Quinta-feira");
                break;
            case 5:
                Console.WriteLine("Sexta-feira");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Entrada inválida");
                break;
        }

        // Utilizando o mesmo código para valores diferentes
        Console.WriteLine("Digite um mês: ");
        var mes = Console.ReadLine()?.ToLower();

        switch (mes)
        {
            case "fevereiro":
                Console.WriteLine("Este mês tem 28 ou 29 dias.");
                break;
            case "janeiro":
            case "março":
            case "maio":
            case "julho":
            case "agosto":
            case "outubro":
            case "dezembro":
                Console.WriteLine("Este mês tem 31 dias.");
                break;
            case "abril":
            case "junho":
            case "setembro":
            case "novembro":
                Console.WriteLine("Este mês tem 30 dias.");
                break;
            default:
                Console.WriteLine("Entrada inválida.");
                break;
        }

        // Case guard
        DisplayMeasurements(4, 3);
        DisplayMeasurements(5, 5);
        
    }

    private static void DisplayMeasurements(int a, int b)
    {
        switch (a, b)
        {
            // Case guard: condicional a mais para ser avaliada
            case (> 0, > 0) when a == b:
                Console.WriteLine($"Both measurements are valid and equal to {a}.");
                break;
            case (> 0, > 0):
                Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
                break;
            default:
                Console.WriteLine("One or both measurements are not valid.");
                break;
        }
    }
}