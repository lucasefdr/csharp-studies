namespace CS04Collections.Generics;

public static class GerericsTest
{
    public static void RunGenerics()
    {
        GenericArrayList<int> galInt = new();
        galInt.Add(1);
        galInt.Add(2);

        for (int i = 0; i < galInt.Count; i++)
        {
            Console.WriteLine(galInt[i]);
        }

        GenericArrayList<Person> galPerson = new();
        galPerson.Add(new Person("Lucas"));
        galPerson.Add(new Person("Eduardo"));

        // Utilizando for i (a classe GenericArrayList tem implementação de indexador)
        for (int i = 0; i < galPerson.Count; i++)
        {
            Console.WriteLine(galPerson[i]);
        }

        // Utilizando foreach (a classe GenericArrayList tem implementação de IEnumerable)
        foreach (Person person in galPerson)
        {
            Console.WriteLine(person);
        }


    }

    class Person(string name)
    {
        public string Name { get; set; } = name;

        public override string? ToString() => Name;
    }
}
