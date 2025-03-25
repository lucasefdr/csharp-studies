namespace CS04Collections.GenericList;

public class GenericList
{
    public static void ListRun()
    {
        #region Inicialização
        var listOfNumbers1 = new List<int>();
        List<int> listOfNumbers2 = new();
        var listOfNumbers3 = new List<int> { 1, 2, 3, 4, 5 };

        // Inicializando uma lista a partir de um array
        var arrayOfNumbers = new int[] { 1, 2, 3, 4, 5 };
        var listFromArray = new List<int>(arrayOfNumbers);
        #endregion

        #region Métodos e propriedades
        /*** Inserção ***/
        listOfNumbers1.Add(1);
        listOfNumbers1.Add(2);
        listOfNumbers1.Add(3);
        listOfNumbers1.Add(4);

        // Adiciona um range de valores
        listOfNumbers2.AddRange(listOfNumbers1);

        /*** Propriedades ***/
        // Total de elementos
        var count = listOfNumbers2.Count;

        // Capacidade da lista
        var capacity = listOfNumbers2.Capacity;

        /*** Validação ***/
        var containsTrue = listOfNumbers2.Contains(1);
        var containsFalse = listOfNumbers2.Contains(5);

        // Verifica se contém elementos na lista de acordo com uma condição
        var existsTrue = listOfNumbers2.Exists(e => e % 2 == 0);

        /*** Ordenação e inversão ***/
        // Ordena a lista
        listOfNumbers2.Sort();

        // Reverte a lista
        listOfNumbers2.Reverse();

        /*** Iteração ***/
        // Acessando elementos da lista
        listOfNumbers2.ForEach(e => e *= 2);

        /*** Busca ***/
        // Find: retorna a primeira ocorrência que atende a condição
        var find = listOfNumbers2.Find(e => e == 1);

        // FindAll: retorna uma lista com os elementos que atendem a condição
        var findAll = listOfNumbers2.FindAll(e => e > 1);

        /*** Remoção ***/
        // Removendo elemento
        listOfNumbers1.Remove(1);

        // Removendo elementos através de uma condição
        listOfNumbers1.RemoveAll(e => e > 2);

        // Remove todos os elementos da lista
        listOfNumbers2.Clear();
        #endregion
    }
}
