namespace CS01Fundamentals.Classes;

public static class A12IncrementDecrementOperators
{
    public static void RunIncrementDecrement()
    {
        var x = 10;

        // Operadore de incremento 
        x++; // x = x + 1
        Console.WriteLine($"x++: {x}");

        // Operador de decremento
        x--; // x = x - 1
        Console.WriteLine($"x--: {x}");

        // Operador de incremento antes da variável
        Console.WriteLine($"++x: {++x}");

        // Operador de decremento antes da variável
        Console.WriteLine($"--x: {--x}");

        // Operador de incremento depois da variável
        Console.WriteLine($"x++: {x++}");
        Console.WriteLine($"Incremento depois da variável: {x}");

        // Operador de decremento depois da variável
        Console.WriteLine($"x--: {x--}");
        Console.WriteLine($"Decremento depois da variável: {x}");
    }
}