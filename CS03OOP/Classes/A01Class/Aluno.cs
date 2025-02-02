namespace CS03POO.Classes.A01Class;

public class Aluno
{
    public string? Nome;
    public int Idade;

    #region Construtores

    // Construtor vazio
    public Aluno()
    {
    }

    // Construtores com parâmetros
    public Aluno(string? nome) => Nome = nome;

    // Sobrecarga de construtor
    public Aluno(string? nome, int idade) : this(nome) => Idade = idade;

    #endregion
}