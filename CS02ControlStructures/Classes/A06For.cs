namespace CS02ControlStructures.Classes;

public static class A06For
{
    public static void Run()
    {
        Console.WriteLine("==> FOR");

        for (var i = 1; i <= 5; i++)
        {
            for (var j = 1; j <= 5; j++)
            {
                Console.Write($"({i},{j})");
            }

            Console.WriteLine();
        }

        // Tabuada com FOR
        Console.WriteLine("Digite o número para calcular a tabuada: ");
        var numero = Convert.ToInt32(Console.ReadLine());

        if (numero <= 0) return;

        for (var i = 1; i <= 10; i++)
        {
            var resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        // Múltiplas expressões com for
        for (int i = 1, j = 1; i + j <= 10; i++, j++)
        {
            Console.WriteLine($"i = {i} / j = {j}");
        }

        // Seções opcionais
        var x = 1;
        for (; x <= 10;)
        {
            Console.WriteLine($"Loop for: seções opcionais {x}");
            x++;
        }

        // Loop infinito
        var y = 1;

        for (;;)
        {
            Console.WriteLine($"Loop for infinito: {y}");
            y++;
            if (y > 10) break;
        }

        // For each
        var array = new[] { 1, 2, 3 };

        foreach (var n in array)
        {
            Console.WriteLine(n);
        }
    }
}