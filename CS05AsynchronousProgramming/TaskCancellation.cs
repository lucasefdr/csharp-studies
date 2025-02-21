namespace CS05AsynchronousProgramming;

internal class TaskCancellation
{
    public static async Task ExecuteWithCancellationTokenAfterTime()
    {
        using var cts = new CancellationTokenSource();

        // Cancelamento após 5 segundos
        cts.CancelAfter(TimeSpan.FromSeconds(5));

        Task downloadTask = DownloadAsync(15, cts.Token);

        // Cancelamento ao pressionar enter
        Task cancelTask = Task.Run(() =>
        {
            Console.WriteLine("Press enter to cancel the operation");
            Console.ReadKey(true);
            cts.Cancel();
        });

        try
        {
            await downloadTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation is canceled.");
        }
    }

    private static async Task DownloadAsync(int totalFiles, CancellationToken cancellationToken)
    {
        for (int file = 0; file < totalFiles; file++)
        {
            // Verifica se o cancelamento foi solicitado
            cancellationToken.ThrowIfCancellationRequested();

            Console.WriteLine($"Download file {file}");
            await Task.Delay(1000, cancellationToken);
        }
    }
}
