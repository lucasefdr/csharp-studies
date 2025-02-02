namespace CS01Fundamentals.Classes;

public static class A03ReferenceTypes
{
    public static void StringType()
    {
        Console.WriteLine();
        Console.WriteLine("==> Reference Types");

        string name = "Lucas";
        string surname = "Ferreira";
        string fullName = name + " " + surname;

        Console.WriteLine(fullName);
    }

    public static void ObjectType()
    {
        Console.WriteLine();
        Console.WriteLine("==> Reference Types");

        object obj1 = "Lucas";
        object obj2 = 3;
        object obj3 = 3.09f;
        object obj4 = true;

        Console.WriteLine(obj1);
        Console.WriteLine(obj2);
        Console.WriteLine(obj3);
        Console.WriteLine(obj4);
    }
}