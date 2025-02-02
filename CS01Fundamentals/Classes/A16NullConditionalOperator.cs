namespace CS01Fundamentals.Classes;

public static class A16NullConditionalOperator
{
    public static void Run()
    {
        string? name = null;
        Console.WriteLine(name?.Length);
        
        // Utilizando ?. para evitar NullReferenceException
        Car? car = null;
        Console.WriteLine(car?.Model ?? "Carro sem modelo.");
    }
    
    private class Car
    {
        public string Model { get; set; }
    }
    
}