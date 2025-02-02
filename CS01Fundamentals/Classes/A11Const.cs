namespace CS01Fundamentals.Classes;

public static class A11Const
{
    public static void RunConst()
    {
        // Declarando constantes
        const int DAYS = 365;
        const int MONTH = 30, WEEK = 7, YEAR = 65;
        Console.WriteLine($"Days in a year: {DAYS}");
        Console.WriteLine($"Days in a month: {MONTH}");
        Console.WriteLine($"Days in a week: {WEEK}");
        Console.WriteLine($"Days in a year: {YEAR}");

        // Uma constante deve ser inicializada
        // const int HOURS; // => Erro de compilação

        // Uma constante não pode ter seu valor alterado
        const string NAME = "Lucas";
        // NAME = "Lucas Eduardo"; // => Erro de compilação

        // Exemplos com constantes
        var perimeter = 2 * Math.PI * 10;
        Console.WriteLine($"Perimeter of a circle with radius 10: {perimeter}");
        var area = Math.PI * 10 * 10;
        Console.WriteLine($"Area of a circle with radius 10: {area}");
    }
}