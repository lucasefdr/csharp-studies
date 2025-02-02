namespace CS01Fundamentals.Exercises;

public static class E02Fundamentals
{
    public static void Run()
    {
        // Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
        // Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.
        Console.WriteLine("==> Exercício 1");
        var nome = "Paulo";
        var idade = 17;
        var nota = 7.5;
        Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}.");

        // Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
        // escapes.
        Console.WriteLine("==> Exercício 2");
        Console.WriteLine($"Nome: {nome}\n Idade: {idade}\n Nota: {nota}");

        // Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
        // a concatenação e também a interpolação de strings.
        Console.WriteLine("==> Exercício 3");
        Console.WriteLine("Digite 1 letra: ");
        var primeiraLetra = Console.ReadLine();
        Console.WriteLine("Digite 1 letra: ");
        var segundaLetra = Console.ReadLine();
        Console.WriteLine("Digite 1 letra: ");
        var terceiraLetra = Console.ReadLine();

        Console.WriteLine($"{terceiraLetra}{segundaLetra}{primeiraLetra}");

        // Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
        // a b e c .
        Console.WriteLine("==> Exercício 4");
        int a = 1, b = 12, c = -13;

        var delta = Math.Pow(b, 2) - 4 * a * c;
        var x1 = (-b + Math.Sqrt(delta)) / 2 * a;
        var x2 = (-b - Math.Sqrt(delta)) / 2 * a;

        Console.WriteLine($"a = {a}, b = {b}, c = {c}" +
                          $"Delta: {delta}" +
                          $"x1 = {x1}, x2 = {x2}");

        // Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
        // Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
        // então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
        // inválido’: (use o operador condicional ternário)
        Console.WriteLine("==> Exercício 5");
        Console.WriteLine("Digite o login: ");
        var login = Console.ReadLine();
        Console.WriteLine("Digite a senha: ");
        var senhaValida = int.TryParse(Console.ReadLine(), out var senha);

        if (senhaValida)
        {
            var mensagem = (login!.Equals("admin") || login.Equals("maria")) && senha == 123
                ? "Login feito com sucesso"
                : "Login inválido";

            Console.WriteLine(mensagem);
        }
    }
}