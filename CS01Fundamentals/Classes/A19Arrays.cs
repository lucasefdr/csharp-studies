namespace CS01Fundamentals.Classes;

public class A19Arrays
{
    public static void RunArrays()
    {
        ArrayClass();
    }

    private static void UniArrays()
    {
        // Declarando sem inicializar com tamanho fixo de 2
        string[] arr0 = new string[2];

        // Declaração inicializando valores
        string[] arr1 = new string[] { "Lucas", "Eduardo" };
        string[] arr2 = { "Lucas", "Eduardo" };

        // Usando collection expression
        string[] arr3 = ["Lucas", "Eduardo"];

        // Inserindo elementos
        arr0[0] = "Lucas";
        arr0[1] = "Eduardo";

        // Iterando sobre elementos
        for (int i = 0; i < arr0.Length; i++) {
            Console.WriteLine(arr0[i]);
        }

        foreach (var name in arr1)
        {
            Console.WriteLine(name);
        }
    }

    private static void MultiArrays()
    {
        string[,] arr0 = new string[1, 2];
        arr0[0, 0] = "Lucas";
        arr0[0, 1] = "Eduardo";

        int[,] arr1 = new int[3, 3] { { 1, 2, 3 }, { 3, 2, 1 }, { 9, 9, 9 } };
        int[,,] arr2 = new int[2, 2, 2];
        arr2[0, 0, 0] = 1;
        arr2[0, 0, 1] = 2;
        arr2[0, 1, 0] = 3;
        arr2[0, 1, 1] = 4;
        arr2[1, 0, 0] = 5;
        arr2[1, 0, 1] = 6;
        arr2[1, 1, 0] = 7;
        arr2[1, 1, 1] = 8;

        // Retorna o número total de elementos do array
        Console.WriteLine(arr2.Length);
        // Retorna o número de dimensões do array
        Console.WriteLine(arr2.Rank);

        // Iteração em arrays multidimensionais
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            Console.WriteLine($"Camada {i}");
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                Console.WriteLine($"Linha {j}");
                for (int k = 0;  k < arr2.GetLength(2); k++)
                {
                    Console.WriteLine($"Coluna: {arr2[i, j, k]}");
                }
            }
        }

    }

    private static void JaggedArrays()
    {
        // Declaração de uma jagged array
        int[][] ints = { new int[] { 1, 2 }, new int[] { 4, 5, 6 } };

        // Usando collection expression
        int[][] intsCE = [[1, 2], [4, 5, 6]];

        // Acessando valores
        Console.WriteLine(intsCE[1][2]);

    }

    private static void ArrayClass()
    {
        int[] numbers = [7, 8, 6, 4, 3];
        // Ordena 
        Array.Sort(numbers);
        
        Console.WriteLine(string.Join(", ", numbers));

        // Busca o índice
        Console.WriteLine($"Index of: {Array.IndexOf(numbers, 4)}");

        // Conversão de tipos do array
        string[] strings = Array.ConvertAll(numbers, n =>  n.ToString());
        foreach (string s in strings) Console.WriteLine($"New type: {s.GetType().Name}");
    }
}
