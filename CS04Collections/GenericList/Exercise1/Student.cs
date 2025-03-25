namespace CS04Collections.GenericList.Exercise1;

internal class Student
{
    public Student(string name)
    {
        Name = name;
        Grades = [];
    }

    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double Average => Grades.Any() ? Grades.Average() : 0;
}
