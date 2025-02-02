namespace CS03POO.Classes.A01Class;

// Classe: abstração de conceitos do mundo real
public class Pessoa
{
    #region Fields (campos)

    public string? Nome;
    public int Idade;
    public string? Sexo;

    #endregion

    #region Constructors (construtores)

    public Pessoa()
    {
    }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    #endregion

    #region Methods (métodos)

    public void Saudacao()
        => Console.WriteLine(Nome is not null ? $"Olá, meu nome é {Nome}" : "Olá!");

    public void ExibeMensagem(string mensagem)
        => Console.WriteLine(mensagem);

    #endregion
}