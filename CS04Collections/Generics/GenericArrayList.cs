using System.Collections;

namespace CS04Collections.Generics;

// Classe para simular um array list genérico (ArrayList não tem segurança de tipagem)
internal class GenericArrayList<T> : IEnumerable<T>
{
    // Contador 
    public int Count { get; private set; } = 0;

    // Declara um array para armazenar os dados
    private readonly T[] array = new T[5];

    // Cria um indexador para a classe
    public T this[int i]
    {
        get { return array[i]; }
        set { array[i] = value; }
    }

    // Método para adicionar itens no array
    public void Add(T item)
    {
        if (Count < 5)
        {
            array[Count] = item;
            Count++;
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of bound exception");
        }


    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var value in array)
        {
            yield return value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }
}
