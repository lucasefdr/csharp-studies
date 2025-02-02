namespace CS01Fundamentals.Classes.CustomConvert;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Método para converter Pessoa em Funcionario
    public static explicit operator Employee(Person person)
    {
        return new Employee
        {
            Name = person.Name,
            Age = person.Age
        };
    }
}
