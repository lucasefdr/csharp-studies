namespace CS02ControlStructures.Classes;

public static class A04While
{
    public static void Run()
    {
        Console.WriteLine("==> WHILE");
        var count = 10;

        while (count > 0)
        {
            Console.WriteLine($"Counter: {count}");
            count--;
        }

        // Tabuada com while
        while (true)
        {
            Console.WriteLine("Digite o número para calcular a tabuada: ");
            var entrada = Convert.ToInt32(Console.ReadLine());

            if (entrada > 0)
            {
                var contador = 1;
                while (contador <= 10)
                {
                    Console.WriteLine($"{entrada} x {contador} = {entrada * contador}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida: número menor que 0.");
            }

            Console.WriteLine("Deseja realizar a tabuada de outro número? (S/N)");
            var continuar = Console.ReadLine();

            if (continuar?.ToUpper() == "S") continue;

            Console.WriteLine("Finalizando...");
            Thread.Sleep(3000);
            break;
        }
    }
}