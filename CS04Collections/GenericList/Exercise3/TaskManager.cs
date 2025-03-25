namespace CS04Collections.GenericList.Exercise3;

internal class TaskManager
{
    public List<Task> Tasks { get; private set; } = [];

    public void AddTask(Task task)
    {
        var existingTask = Tasks.FirstOrDefault(t => t.Title == task.Title);

        if (existingTask != null)
            throw new ArgumentException("Essa tarefa já existe");

        Tasks.Add(task);
    }

    public void TaskDone(string title)
    {
        var existingTask = Tasks.FirstOrDefault(t => t.Title == title) ?? throw new ArgumentException("Essa tarefa não existe nesse contexto");
        Tasks.Remove(existingTask);
    }

    public List<Task> Filter(string? tag, Priority? priority, DateOnly? startDate, DateOnly? endDate)
    {
        var queryable = Tasks.AsQueryable();

        if (!string.IsNullOrWhiteSpace(tag))
        {
            queryable = queryable.Where(t => t.Tags.Contains(tag));
        }

        if (priority != null)
        {
            queryable = queryable.Where(t => t.Priority == priority);
        }

        if (startDate != null && endDate != null)
        {
            queryable = queryable.Where(t => t.DueDate >= startDate && t.DueDate <= endDate);
        }

        return [.. queryable];
    }

    public void OrderByPriority()
    {
        Tasks = [.. Tasks.OrderByDescending(t => t.Priority)];
    }

    public void OrderByDueDate()
    {
        Tasks = [.. Tasks.OrderByDescending(t => t.DueDate)];
    }

    public void Statistics()
    {
        var stats = Tasks
                    .GroupBy(t => t.Priority)
                    .ToDictionary(g => g.Key, g => g.Count());

        foreach (var item in stats)
        {
            Console.WriteLine($"Prioridade: {item.Key} - Quantidade: {item.Value}");
        }
    }
}
