namespace CS01Fundamentals.Classes;

public static class A14LogicalOperators
{
    public static void Run()
    {
        // Operador unário de negação (!)
        Console.WriteLine(!true);
        Console.WriteLine(!false);
        
        // Operadores lógicos binários !, &, ^
        var a1 = false & SecondOperand();
        Console.WriteLine(a1);

        var a2 = true & SecondOperand();
        Console.WriteLine(a2);

        // XOR 
        Console.WriteLine($"true ^ false = {true ^ false}"); // Retorna True porque são diferentes
        Console.WriteLine($"true ^ true = {true ^ true}");  // Retorna False porque são iguais 
        
        // Operadores lógicos binários ||, &&
        Console.WriteLine($"true && true = {true && true}"); // Retorna True porque ambos são verdadeiros
        Console.WriteLine($"true && false = {true && false}"); // Retorna False porque um é falso
        Console.WriteLine($"false && false = {false && false}"); // Retorna False porque ambos são falsos
        Console.WriteLine($"true || true = {true || true}"); // Retorna True porque ambos são verdadeiros
        Console.WriteLine($"true || false = {true || false}"); // Retorna True porque um é verdadeiro
        Console.WriteLine($"false || false = {false || false}"); // Retorna False porque ambos são falsos


    }
    
    private static bool SecondOperand()
    {
        Console.WriteLine("Avaliando segundo operando...");
        return true;
    }
}