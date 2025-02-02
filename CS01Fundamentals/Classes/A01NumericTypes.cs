namespace CS01Fundamentals.Classes;

public static class A01NumericTypes
{
    public static void IntegralTypes()
    {
        Console.WriteLine("==> Integral Types");

        byte minByte = byte.MinValue;
        byte maxByte = byte.MaxValue;
        long minLong = long.MinValue;
        long maxLong = long.MaxValue;

        Console.WriteLine($"byte: {minByte} to {maxByte}");
        Console.WriteLine($"long: {minLong} to {maxLong}");
    }

    public static void FloatingPointTypes()
    {
        Console.WriteLine();
        Console.WriteLine("==> Floating Point Types");

        float floatNumber = 3.14f; // f is required to indicate that this is a float
        double doubleNumber = 3.14d; // d is optional, but it's a good practice to include it
        decimal decimalNumber = 3.14m; // m is required to indicate that this is a decimal

        Console.WriteLine($"float: {floatNumber}");
        Console.WriteLine($"double: {doubleNumber}");
        Console.WriteLine($"decimal: {decimalNumber}");

        // Floating point types have precision limitations
        float floatX = 1f / 3;
        double doubleX = 1d / 3;
        decimal decimalX = 1m / 3;

        Console.WriteLine($"float precision: {floatX}");
        Console.WriteLine($"double precision: {doubleX}");
        Console.WriteLine($"decimal precision: {decimalX}");
    }
}