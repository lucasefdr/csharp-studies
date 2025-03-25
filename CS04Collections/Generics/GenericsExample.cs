using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace CS04Collections.Generics;

internal class GenericsExample
{
    public static void Main()
    {
        ArrayList array = [1997, "String example", new Person("Lucas")];

        foreach (var item in array)
        {
            Console.WriteLine(item.GetType());
        }
    }


}
class Person(string name)
{
    public string Name { get; set; } = name;
}

class GenericList<T> : IEnumerable<T>
{
    public int Count { get; private set; } = 0;
    private readonly T[] array = new T[10];
    public T this[int i]
    {
        get { return array[i]; }
        set { array[i] = value; }
    }

    public void Add(T item)
    {
        if (Count < array.Length)
        {
            array[Count++] = item;
        }
    }


    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in array) yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}