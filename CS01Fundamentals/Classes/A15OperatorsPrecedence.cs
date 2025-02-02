namespace CS01Fundamentals.Classes;

public static class A15OperatorsPrecedence
{
    public static void Run()
    {
        int a = 10 - 2 * 3; // 4
        int b = (10 - 2) * 3; // 24
        Console.WriteLine($"10 - 2 x 3 = {a}"); 
        Console.WriteLine($"(10 - 2) x 3 = {b}");

        bool c = !(9 != 8) && 5 >= 7 || 8 >= 6; // True
        bool d = !(9 != 8) && (5 >= 7 || 8 >= 6); // False
        Console.WriteLine($"!(9 != 8) && 5 >= 7 || 8 >= 6 = {c}");
        Console.WriteLine($"!(9 != 8) && (5 >= 7 || 8 >= 6) = {d}");

        int x = 5, y = 10, z = 15;
        int e = --x * y - ++z; // 4 * 10 - 16 = 24
        Console.WriteLine($"--x * y - ++z = {e}");
    }
}