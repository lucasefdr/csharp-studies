using System.Globalization;

namespace CS02ControlStructures.Exercises;

public static class E01ControlStructrures
{
    public static void Run()
    {
        // Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
        Console.WriteLine("Digite o primeiro número: ");
        var num1 = int.Parse(Console.ReadLine() ?? throw new InvalidCastException(), NumberStyles.Integer);
        Console.WriteLine("Digite o segundo número: ");
        var num2 = int.Parse(Console.ReadLine() ?? throw new InvalidCastException(), NumberStyles.Integer);
        Console.WriteLine("Digite o terceiro número: ");
        var num3 = int.Parse(Console.ReadLine() ?? throw new InvalidCastException(), NumberStyles.Integer);

        var maior = num1;
        if (num2 > num1 || num3 > num1)
        {
            maior = num2 > num3 ? num2 : num3;
        }

        Console.WriteLine($"\tO número maior é o {maior}");

        // Escreva um programa para calcular a raiz da equação quadrática
        int a, b, c;
        Console.WriteLine("Digite os valores de A, B e C separados por vírgula (ex: 1,2,3):");
        var entrada = Console.ReadLine()?.Split(',', StringSplitOptions.TrimEntries);

        if (entrada == null) throw new ArgumentNullException();

        a = Convert.ToInt32(entrada[0]);
        b = Convert.ToInt32(entrada[1]);
        c = Convert.ToInt32(entrada[2]);

        var delta = Math.Pow(b, 2) - 4 * a * c;
        var x1 = (-b + Math.Sqrt(delta)) / 2 * a;
        var x2 = (-b - Math.Sqrt(delta)) / 2 * a;

        if (x1 is double.NaN || x2 is double.NaN)
            Console.WriteLine("Sem solução para números reais.");
        else
            Console.WriteLine($"Raízes: {x1} e {x2}");

        // Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop
        // while, do-while e for
        int sum = 0, index = 1;

        while (index <= 10)
        {
            Console.Write(index + " ");
            sum += index;
            index++;
        }

        Console.WriteLine($"A soma dos números é {sum} ==> while");

        sum = 0;
        index = 1;
        do
        {
            Console.Write(index + " ");
            sum += index;
            index++;
        } while (index <= 10);

        Console.WriteLine($"A soma dos números é {sum} ==> do-while");

        sum = 0;
        for (index = 1; index <= 10; index++)
        {
            Console.Write(index + " ");
            sum += index;
        }

        Console.WriteLine($"A soma dos números é {sum} ==> for");
    }
}