namespace CS01Fundamentals.Classes;

public static class A02BoolChar
{
    public static void BoolType()
    {
        Console.WriteLine();
        Console.WriteLine("==> Bool Type");

        bool isTrue = true;
        bool isFalse = false;

        Console.WriteLine($"true: {isTrue}");
        Console.WriteLine($"false: {isFalse}");
    }

    public static void CharType()
    {
        Console.WriteLine();
        Console.WriteLine("==> Char Type");

        char letter = 'A';
        char number = '1';
        char symbol = '$';

        Console.WriteLine($"letter: {letter}");
        Console.WriteLine($"number: {number}");
        Console.WriteLine($"symbol: {symbol}");

        Console.WriteLine();
        Console.WriteLine("==> Char Methods");

        Console.WriteLine(char.IsLetter(letter));
        Console.WriteLine(char.IsDigit(number));
        Console.WriteLine(char.IsSymbol(symbol));
    }
}