namespace CS03POO.Classes.A01Class;

public static class A02Methods
{
    public static void Run()
    {
        Pessoa pessoa = new("Lucas");

        // Executando método sem parâmetros
        pessoa.Saudacao();

        // Executando método com passagem de parâmetro
        pessoa.ExibeMensagem("Exibe mensagem como parâmetro");

        Curso curso = new();
        curso.Resultado(pessoa, true);
    }
}