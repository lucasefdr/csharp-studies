namespace CS01Fundamentals.Classes;

public static class A06Output
{
    public static void DataOutput()
    {
        string name = "Lucas";
        string lastName = "Ferreira";

        // Concatenação
        Console.WriteLine(name + " " + lastName);
        // Interpolação
        Console.WriteLine($"{name} {lastName}");
        // Place holders
        Console.WriteLine("{0} {1}", name, lastName);

        string local = "c:\\wsLucas\\teste";
        string phrase = "Ele disse:\"Isso é um teste\"";
        string text = "Primeira linha\n" +
                      "\tNova linha\n" +
                      "\tÚltima linha";

        Console.WriteLine(text);
    }
}