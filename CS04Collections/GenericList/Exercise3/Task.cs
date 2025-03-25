namespace CS04Collections.GenericList.Exercise3;

internal class Task : IEquatable<Task>
{
    public string Title { get; }
    public string Description { get; }
    public DateOnly DueDate { get; private set; }
    public Priority Priority { get; private set; }
    private HashSet<string> _tags = [];

    public Task(string title, string description, DateOnly dueDate, Priority priority, IEnumerable<string> tags)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Título inválido.");

        Title = title;
        Description = description;
        DueDate = dueDate;
        Priority = priority;
        foreach (var tag in tags) _tags.Add(tag);
    }

    public void AddTag(string tag) => _tags.Add(tag);
    public void RemoveTag(string tag) => _tags.Remove(tag);
    public IReadOnlyCollection<string> Tags => _tags.ToList().AsReadOnly();
    public void UpdateDueDate(DateOnly newDate) => DueDate = newDate;
    public bool Equals(Task? other) => other?.Title == Title;
    public override bool Equals(object? obj) => Equals(obj as Task);
    public override int GetHashCode() => Title.GetHashCode();
}

public enum Priority
{
    Low,
    Medium,
    High
}
