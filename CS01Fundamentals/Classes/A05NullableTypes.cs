namespace CS01Fundamentals.Classes;

public static class A05NullableTypes
{
    public static void NullableTypes()
    {
        Console.WriteLine();
        Console.WriteLine("==> Nullable Types");

        // Nullable types são tipos de valor que podem ser nulos
        Nullable<bool> b1 = null; // Nullable<bool> é o mesmo que bool?

        // Outra forma de declarar um tipo nullable é usando o operador '?'
        bool? b2 = null;

        // Não podemos converter um valor nulo a um tipo de valor
        int? i1 = null;
        // int i2 = i1; // Erro de compilação
        // Para contornar isso, podemos aplicar o operador de coalescência nula
        int i2 = i1 ?? 0;
        // Ou usar o método GetValueOrDefault()
        int i3 = i1.GetValueOrDefault();

        Console.WriteLine(i2);
        Console.WriteLine(i3);

        // Podemos usar a propriedade HasValue para verificar se o valor é nulo e Value para obter o valor
        float? f1 = 3.14f;
        if (f1.HasValue) Console.WriteLine(f1.Value);
    }
}