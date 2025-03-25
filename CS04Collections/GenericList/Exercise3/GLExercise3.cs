namespace CS04Collections.GenericList.Exercise3;

internal static class GLExercise3
{
    public static void Execute()
    {
        var task1 = new Task("Arrumar a casa", "Arrumar a casal", DateOnly.Parse("17/03/2025"), Priority.Low, ["Casa"]);
        var task2 = new Task("Ir na academia", "Ir na academia", DateOnly.Parse("19/03/2025"), Priority.Medium, ["Saúde"]);
        var task3 = new Task("Pagar o cartão de crédito", "Pagar o cartão de crédito", DateOnly.Parse("25/03/2025"), Priority.Low, ["Finanças"]);
        var task4 = new Task("Ir caminhar", "Ir caminhar", DateOnly.Parse("19/03/2025"), Priority.Low, ["Saúde"]);

        var taskManager = new TaskManager();
        // Adicionando tarefas ao gerenciador de tarefas
        taskManager.AddTask(task1);
        taskManager.AddTask(task2);
        taskManager.AddTask(task3);
        taskManager.AddTask(task4);

        // Filtrando tarefas 
        var filteredTasks = taskManager.Filter("Saúde", Priority.Medium, null, null);
        Console.WriteLine("Tasks com a tag saúde e prioridade média:");
        filteredTasks.ForEach(task =>
        {
            Console.WriteLine($"- {task.Title}");
        });

        // Ordenando tarefas
        taskManager.OrderByDueDate();
        taskManager.Tasks.ForEach(task => Console.WriteLine($"Tarefa: {task.Title} - Data: {task.DueDate}"));

        // Conclui tarefas
        taskManager.TaskDone(task1.Title);
        if (!taskManager.Tasks.Exists(task => task.Title == task1.Title))
        {
            Console.WriteLine("Tarefa removida com sucesso!");
        }

        taskManager.Statistics();

    }
}
