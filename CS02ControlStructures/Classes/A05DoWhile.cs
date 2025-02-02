namespace CS02ControlStructures.Classes;

public static class A05DoWhile
{
    public static void Run()
    {
        Console.WriteLine("==> DO WHILE");
        var continuar = true;

        do
        {
            Console.WriteLine("Dentro do DO WHILE");
            Console.WriteLine("\tDeseja Continuar? (S/N)");
            var resposta = Console.ReadLine();

            continuar = resposta?.ToUpper() == "S";
        } while (continuar);

        Console.WriteLine("Finalizando...");
        Thread.Sleep(3000);
    }
}