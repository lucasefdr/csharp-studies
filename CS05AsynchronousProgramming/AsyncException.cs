namespace CS05AsynchronousProgramming;

internal class AsyncException
{

    private static Task RunExceptionAsync()
    {
        return Task.Run(() =>
        {
            throw new Exception("Async exception");
        });
    }

    public static async void CallExceptionAsync()
    {
        try
        {
            await RunExceptionAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static async Task RunMultipleExceptions()
    {
        Task? tasks = null;
        try
        {
            var firstTask = Task.Run(() =>
            {
                Task.Delay(TimeSpan.FromSeconds(10));
                throw new InvalidCastException("Invalid Cast Exception");
            });

            var secondTask = Task.Run(() =>
            {
                Task.Delay(TimeSpan.FromSeconds(5));
                throw new EndOfStreamException("End of Stream Exception");
            });

            tasks = Task.WhenAll(firstTask, secondTask);
            await tasks;
        }
        catch
        {
            Console.WriteLine("==> Exceptions:");
            var allExceptions = tasks!.Exception;

            foreach (var exception in allExceptions!.InnerExceptions)
            {
                Console.WriteLine(exception.GetType() + " - " + exception.Message);
            }
        }
    }
}
