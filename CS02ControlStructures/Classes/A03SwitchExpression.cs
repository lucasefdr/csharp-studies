namespace CS02ControlStructures.Classes;

public static class A03SwitchExpression
{
    public static void Run()
    {
        const Direction direction = Direction.Right;
        Console.WriteLine($"Map view direction is {direction}");
        Console.WriteLine($"Cardinal orientation is {ToOrientation(direction)}");

        const Product product = Product.Book;
        var price = PriceCalculator(product);
        Console.WriteLine($"The price is ${price}");

        // Utilizando switch expression com pattern matching
        object obj = 3.14;

        var result = obj switch
        {
            int n and > 0 => $"Número positivo: {n}",
            int n and < 0 => $"Número negativo: {n}",
            double d => $"Número decimal: {d}",
            string s => $"String: {s}",
            _ => "Outro tipo ou valor nulo"
        };

        Console.WriteLine(result);
    }

    // Switch expression
    private static Orientation ToOrientation(Direction direction) => direction switch
    {
        Direction.Up => Orientation.North,
        Direction.Right => Orientation.East,
        Direction.Down => Orientation.South,
        Direction.Left => Orientation.West,
        _ => throw new ArgumentException($"Not expected direction value: {direction}", nameof(direction))
    };

    private static decimal PriceCalculator(Product product) => product switch
    {
        Product.Book => 10.99m,
        Product.Cellphone => 999.99m,
        Product.Computer => 1249.99m,
        _ => 00.00m
    };
};

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public enum Orientation
{
    North,
    South,
    East,
    West
}

public enum Product
{
    Book,
    Cellphone,
    Computer
}