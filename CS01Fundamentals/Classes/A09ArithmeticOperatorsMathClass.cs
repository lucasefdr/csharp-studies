namespace CS01Fundamentals.Classes;

public static class A09ArithmeticOperatorsMathClass
{
    public static void RunArithmeticOperators()
    {
        int x = 32;
        int y = 8;

        Console.WriteLine($"Soma: {x} + {y} = {x + y}");
        Console.WriteLine($"Subtração: {x} - {y} = {x - y}");
        Console.WriteLine($"Multiplicação: {x} * {y} = {x * y}");
        Console.WriteLine($"Divisão: {x} / {y} = {x / y}");
        Console.WriteLine($"Módulo: {x} % {y} = {x % y}");
    }

    public static void RunMathClass()
    {
        // Constantes da classe Math
        const double pi = Math.PI;
        const double e = Math.E;

        Console.WriteLine($"Math.PI: {pi}");
        Console.WriteLine($"Math.E: {e}");

        // Métodos da classe math
        Console.WriteLine($"Math.Abs(-10): {Math.Abs(-10)}"); // Valor absoluto
        Console.WriteLine($"Math.Ceiling(10.15): {Math.Ceiling(10.15)}"); // Arredonda para cima
        Console.WriteLine($"Math.Floor(10.15): {Math.Floor(10.15)}"); // Arredonda para baixo
        Console.WriteLine($"Math.Max(10, 20): {Math.Max(10, 20)}"); // Retorna o maior valor
        Console.WriteLine($"Math.Min(10,20): {Math.Min(10, 20)}"); // Retorna o menor valor
        Console.WriteLine($"Math.Pow(2, 3): {Math.Pow(2, 3)}"); // Potência
        Console.WriteLine($"Math.Sqrt(9): {Math.Sqrt(9)}"); // Raiz quadrada
    }
}