namespace CS01Fundamentals.Classes;

public static class A17TernaryOperator
{
    public static void Run()
    {
        Console.WriteLine("Informe a temperatura: ");
        var tryParseTemp = double.TryParse(Console.ReadLine(), out var temp);

        if (!tryParseTemp) return;

        var resultTemp = temp > 27 ? "Quente" : "Normal";
        Console.WriteLine($"O tempo está {resultTemp}");

        // Operador ternário aninhado
        Console.WriteLine("Informe o valor de X: ");
        var tryParseX = int.TryParse(Console.ReadLine(), out var x);
        Console.WriteLine("Informe o valor de Y: ");
        var tryParseY = int.TryParse(Console.ReadLine(), out var y);

        if (!tryParseX || !tryParseY) return;

        var resultXY =
            x > y ? $"{x} é maior que {y}" :
            x < y ? $"{x} é menor que {y}" :
            x == y ? $"{x} é igual a {y}" : "Sem resultado";

        Console.WriteLine(resultXY);
    }
}