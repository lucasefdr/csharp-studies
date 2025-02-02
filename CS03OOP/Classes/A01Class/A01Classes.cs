namespace CS03POO.Classes.A01Class;

public static class A01Classes
{
    public static void Run()
    {
        #region Instanciando classes

        Pessoa p1 = new Pessoa();
        p1.Nome = "Lucas";
        p1.Idade = 26;
        p1.Sexo = "Masculino";

        var p2 = new Pessoa();
        p2.Nome = "Lucas";
        p2.Idade = 26;
        p2.Sexo = "Masculino";

        Pessoa p3 = new();
        p3.Nome = "Lucas";
        p3.Idade = 26;
        p3.Sexo = "Masculino";

        Pessoa p4 = new()
        {
            Nome = "Lucas",
            Idade = 26,
            Sexo = "Masculino"
        };

        #endregion

        #region Alocação de memória
        // Nesse momento, p5 só tem alocação (ponteiro de referência) na memória stack 
        Pessoa p5;

        // Ao utilizar o new(), estamos criando uma instância na memória heap, para onde o ponteiro
        // p5 irá apontar
        p5 = new Pessoa();
        p5.Nome = "Pessoa Exemplo";
        p5.Idade = 44;
        p5.Sexo = "Masculino";

        // Ao declarar uma nova variável e fazer referência para um objeto já existente, ambos os ponteiros
        // (p5 e p6) irão apontar para a mesma referência da memória heap
        Pessoa p6 = p5;

        // Se alterarmos os campos através de qualquer uma das referências, o objeto presente na heap será alterado
        p6.Nome = "Novo Nome";
        Console.WriteLine(p5.Nome);

        #endregion
    }
}