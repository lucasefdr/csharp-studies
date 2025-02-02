namespace CS01Fundamentals.Classes;

public class A18Strings
{
    public static void RunStringTests()
    {
        string fullName = "Lucas Eduardo";
        string emptyString = string.Empty;

        // Tamanho da string
        Console.WriteLine(fullName.Length);

        // Verifica se a string é vazia 
        Console.WriteLine(emptyString);

        // Deixa maiúsculo
        Console.WriteLine(fullName.ToUpper());

        // Deixa minúsculo
        Console.WriteLine(fullName.ToLower());

        // Separa a string
        string[] names = fullName.Split(' ');
        foreach (var name in names) Console.WriteLine(name);

        // Remove espaços vazios 
        string newString = "  Test remove space     ";
        Console.WriteLine(newString.Trim());
        Console.WriteLine(newString.TrimEnd());
        Console.WriteLine(newString.TrimStart());

        // Valida se a string é vazia ou nula
        Console.WriteLine(string.IsNullOrWhiteSpace(emptyString));
        Console.WriteLine(string.IsNullOrWhiteSpace(newString));

        // Substitui na string
        string test = "Test Oracle";
        string newTest = test.Replace("Oracle", "MySQL");
        Console.WriteLine(newTest);
    }
}
