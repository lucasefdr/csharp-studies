namespace CS04Collections.GenericList.Exercise1;

public static class GLExercise1
{
    public static void Execute()
    {
        // Criação de alunos
        var student1 = new Student("Lucas");
        var student2 = new Student("Eduardo");
        var student3 = new Student("Marcos");

        // Adicionando notas aos alunos
        student1.Grades.Add(10);
        student1.Grades.Add(7.75);
        student1.Grades.Add(8.25);

        student2.Grades.AddRange([10, 10, 6.25]);

        student3.Grades.AddRange([4, 5.25, 7.40]);

        // Calculando a média de um aluno específico
        var student1GradeAverage = student1.Grades.Average();
        var student2GradeAverage = student2.Grades.Average();
        var student3GradeAverage = student3.Grades.Average();

        // Criando uma lista de alunos
        var students = new List<Student> { student1, student2, student3 };

        // Calculando a média de notas dos alunos e exibindo no console
        foreach (var student in students)
        {
            Console.WriteLine($"Aluno: {student.Name} - Média: {student.Average:F2}");
        }

        // Removendo um aluno da lista de alunos
        students.Remove(student3);

        // Validando se esse aluno foi removido 
        if (!students.Contains(student3))
            Console.WriteLine("Aluno removido com sucesso!");

        // Validando se um aluno está na lista
        if (students.Exists(s => s.Name.Equals("Lucas", StringComparison.OrdinalIgnoreCase)))
            Console.WriteLine("Aluno Lucas está na lista");

        var maxAverage = students.Max(s => s.Grades.Average());

        // Encontrando a maior nota
        // var studentWithMaxAverage = students.First(s => s.Grades.Average() == maxAverage);
        var studentWithMaxAverage = students
                                .OrderByDescending(s => s.Average)
                                .FirstOrDefault();


        if (studentWithMaxAverage != null)
        {
            Console.WriteLine($"Aluno com maior média: {studentWithMaxAverage.Name} - Média: {studentWithMaxAverage.Average:F2}");
        }
    }
}
