namespace CS01Fundamentals.Classes;

public static class A13RelationalOperators
{
    public static void Run()
    {
        Console.WriteLine("*** Relational Operators ***");
        int x = 10, y = 20;

        Console.WriteLine($"x = {x}, y = {y}");

        // Operador de igualdade
        bool isEqual = x == y;
        Console.WriteLine($"x == y: {isEqual}");

        // Operador de diferença
        bool isDifferent = x != y;
        Console.WriteLine($"x != y: {isDifferent}");

        // Operador de maior que
        bool isGreaterThan = x > y;
        Console.WriteLine($"x > y: {isGreaterThan}");

        // Operador de menor que 
        bool isLessThan = x < y;
        Console.WriteLine($"x < y: {isLessThan}");

        // Operador de maior ou igual que
        bool isGreaterOrEqual = x >= y;
        Console.WriteLine($"x >= y: {isGreaterOrEqual}");

        // Operador de menor ou igual que
        bool isLessOrEqual = x <= y;
        Console.WriteLine($"x <= y: {isLessOrEqual}");
    }
}