namespace CS01Fundamentals.Classes.CustomConvert;

public class CustomConvertTest
{
    public static void CustomConvertRun()
    {
        Person person = new()
        {
            Name = "Lucas",
            Age = 27,
        };

        // Conversão explícita através de uma conversão customizada
        Employee employee = (Employee)person;

        Console.WriteLine($"Employee name: {employee.Name}");
        Console.WriteLine($"Employee age: {employee.Age}");
    }
}
