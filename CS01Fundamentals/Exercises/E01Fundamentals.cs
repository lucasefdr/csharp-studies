namespace CS01Fundamentals.Exercises;

public static class E01Fundamentals
{
    public static void Exercises()
    {
        // Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
        // var idade = 35;
        int idade;
        idade = 35;
        Console.WriteLine($"Idade: {idade} ({idade.GetType()})");

        // Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
        string nome = "Maria";
        Console.WriteLine($"Nome: {nome} ({nome.GetType()})");

        // Crie uma variável chamada altura e atribua a ela o valor 3.45.
        float altura = 3.45f;
        Console.WriteLine($"Altura: {altura} ({altura.GetType()})");

        // Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
        DateTime data = new DateTime(year: 1999, month: 09, day: 04);
        Console.WriteLine($"Data: {data.ToShortDateString()} ({data.GetType()})");

        //  Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor.
        const int ano = 12;
        Console.WriteLine($"Ano (const): {ano}");

        // Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
        // Nullable<double> nota = 7.80;
        double? nota = 7.80;
        Console.WriteLine($"Nota (nullable): {nota} ({nota.GetType()})");

        /*
         * Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
         * seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
         * operação de soma)
         */
        int x = 77, y = 66;
        int soma = x + y;
        Console.WriteLine($"{x} + {y} = {soma}");
    }
}