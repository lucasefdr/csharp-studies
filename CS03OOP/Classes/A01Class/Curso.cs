namespace CS03POO.Classes.A01Class;

public class Curso
{
    public void Resultado(Pessoa pessoa, bool aprovado)
        => Console.WriteLine(aprovado
            ? $"O aluno {pessoa.Nome} foi aprovado"
            : $"O aluno {pessoa.Nome} não foi aprovado");
}