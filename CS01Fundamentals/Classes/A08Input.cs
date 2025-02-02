namespace CS01Fundamentals.Classes;

public static class A08Input
{
    public static void InputData()
    {
        Console.WriteLine("==> Input Data");
        Console.WriteLine("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine(string.IsNullOrEmpty(name) ? "You did not enter your name." : $"Your name is {name}.");

        Console.WriteLine("Enter your age:");
        if (!int.TryParse(Console.ReadLine(), out var age) || age < 0)
            Console.WriteLine("You did not enter a valid age.");
        else
            Console.WriteLine($"Your age is {age}.");
    }
}