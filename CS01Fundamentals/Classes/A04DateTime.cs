namespace CS01Fundamentals.Classes;

public static class A04DateTime
{
    public static void DateTimeType()
    {
        Console.WriteLine();
        Console.WriteLine("==> DateTime");

        // Buscando a data e hora atual
        var dataHoraAtual = DateTime.Now;
        Console.WriteLine(dataHoraAtual);

        // Buscando a data atual
        var dataAtual = DateTime.Today;
        Console.WriteLine(dataAtual);

        // Criando uma data específica DateTime(year: int, month: int, day: int)
        var dataEspecifica = new DateTime(year: 1997, month: 12, day: 31, hour: 12, minute: 30, second: 12);
        Console.WriteLine(dataEspecifica);

        /* Operações com datas e horas */
        // Extrair informações da data
        var day = dataEspecifica.Day;
        var month = dataEspecifica.Month;
        var year = dataEspecifica.Year;
        var hour = dataEspecifica.Hour;
        var minute = dataEspecifica.Minute;
        var second = dataEspecifica.Second;
        Console.WriteLine($"{day}/{month}/{year} {hour}:{minute}:{second}");

        // Adicionar dias, horas, mês, anos, etc.
        var addDays = dataEspecifica.AddDays(1);
        var addMonths = dataEspecifica.AddMonths(12);
        var addYears = dataEspecifica.AddYears(26);
        Console.WriteLine($"Add days: {addDays}");
        Console.WriteLine($"Add months: {addMonths}");
        Console.WriteLine($"Add years: {addYears}");

        // Obter dia da semana e do ano
        var dayOfWeek = dataEspecifica.DayOfWeek;
        var dayOfYear = dataEspecifica.DayOfYear;
        Console.WriteLine($"Day of week: {dayOfWeek}");
        Console.WriteLine($"Day of year: {dayOfYear}");

        // Formatos de data e hora
        Console.WriteLine($"Short date: {dataEspecifica.ToShortDateString()}");
        Console.WriteLine($"Long date: {dataEspecifica.ToLongDateString()}");
    }
}