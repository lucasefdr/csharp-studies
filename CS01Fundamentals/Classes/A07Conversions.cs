using System.Globalization;

namespace CS01Fundamentals.Classes;

public static class A07Conversions
{
    public static void ImplicitConversion()
    {
        int varInt = 10;
        double varDouble = varInt; // Conversão implícita: int para double
        Console.WriteLine(varDouble);
    }

    public static void ExplicitConversion()
    {
        double varDouble = 123.45;
        int varInt = (int)varDouble; // Conversão explícita: double para int - pode ocorrer perda de informação
        Console.WriteLine(varInt);
    }

    public static void ToStringTest()
    {
        int varInt = 123;
        double varDouble = 99.99;
        decimal varDecimal = 12.49m;

        string s1 = varInt.ToString();
        string s2 = varDouble.ToString(CultureInfo.CurrentCulture);
        string s3 = varDecimal.ToString(CultureInfo.CurrentCulture);

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
    }

    public static void ConvertTest()
    {
        const int varInt = 1997;
        var varDouble = Convert.ToDouble(varInt);

        // OverflowException
        // var varByte = Convert.ToByte(varInt);

        Console.WriteLine(varDouble);
    }

    public static void ParseTest()
    {
        string numStrValue = "30";
        int numIntValue = int.Parse(numStrValue);

        Console.WriteLine(numIntValue);
    }

    public static void TryParseTest()
    {
        string numStrValue1 = "30";
        string numStrValue2 = "30A";

        if (int.TryParse(numStrValue1, out int numIntValue))
        {
            Console.WriteLine($"Valor convertido com sucesso: {numIntValue}");
        }
        else
        {
            Console.WriteLine("Erro na conversão");
        }
    }
}