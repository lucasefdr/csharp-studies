namespace CS01Fundamentals.Classes;

public static class A10AssignmentOperators
{
    public static void RunAssignmentOperators()
    {
        var x = 10; // Atribuição

        // Operadores de atribuição
        Console.WriteLine($"x += 3 = {x += 3}"); // Adição
        Console.WriteLine($"x -= 3 = {x -= 3}"); // Subtração
        Console.WriteLine($"x *= 3 = {x *= 3}"); // Multiplicação
        Console.WriteLine($"x /= 3 = {x /= 3}"); // Divisão
        Console.WriteLine($"x %= 3 = {x %= 3}"); // Módulo

        // Operadores de atruibuição com string
        var name = "Lucas";
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"Hello, {name += " Eduardo"}!");
    }
}