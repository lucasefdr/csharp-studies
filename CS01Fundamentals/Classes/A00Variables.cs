namespace CS01Fundamentals.Classes;

class A00Variables
{
    // Variável estática: pode ser acessada sem a necessidade de instanciar a classe
    static string staticVariable = "Variável estática";
    // Variável de instância: pode ser acessada em qualquer lugar da classe, por qualquer método
    string instanceString = "Variável de instância";

    public void Variables()
    {
        // Variável local: pode ser acessada somente dentro do método (localmente)
        string localVariable = "Variável local";

        Console.WriteLine(A00Variables.staticVariable);
        Console.WriteLine(instanceString);
        Console.WriteLine(localVariable);
    }

    public void VariablesPt2()
    {
        // localVariable = "Não é possível acessar, pois não está especificada dentro desse método";
        string localVariable = "Nova declaração. Visível somente dentro de VariablesPt2";
    }

    public void VarKeyword()
    {
        // Inferência de tipo: o compilador irá inferir o tipo string
        var lastName = "Rosa";
    }
}
