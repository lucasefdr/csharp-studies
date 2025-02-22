namespace CS05AsynchronousProgramming;

internal class AsyncBreakfast
{
    private class Bacon { }
    private class Coffee { }
    private class Egg { }
    private class Juice { }
    private class Toast { }

    public static async Task MakeAsyncBreakfast()
    {
        Console.WriteLine("=> Making a breakfast async");

        Coffee cup = PourCoffee();
        Console.WriteLine("Coffee is ready");

        Task<Egg> eggsTask = FryEggsAsync(2);
        Task<Bacon> baconTask = FryBaconAsync(4);
        Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);

        #region WhenAll
        //Console.WriteLine("==> WhenAll...");
        //await Task.WhenAll(eggsTask, baconTask, toastTask);
        //Console.WriteLine("==> WhenAll Finished...");
        #endregion

        #region WhenAny
        var tasks = new List<Task>() { eggsTask, baconTask, toastTask };
        while (tasks.Count > 0)
        {
            Task finishedTask = await Task.WhenAny(tasks);

            if (finishedTask == eggsTask) Console.WriteLine("Eggs are ready");
            else if (finishedTask == baconTask) Console.WriteLine("Bacon is ready");
            else if (finishedTask == toastTask) Console.WriteLine("Toast is ready");
            await finishedTask;

            tasks.Remove(finishedTask);
        }
        #endregion

        // Toast toast = await toastTask;
        Console.WriteLine("Toast is ready");

        // Egg eggs = await eggsTask;
        Console.WriteLine("Eggs are ready");

        // Bacon bacon = await baconTask;
        Console.WriteLine("Bacon is ready");

        Juice juice = PourOJ();
        Console.WriteLine("Juice is ready");



        Console.WriteLine("=> Breakfast async is ready!");
    }

    private static Juice PourOJ()
    {
        Console.WriteLine("Pouring orange juice");
        return new Juice();
    }

    private static Coffee PourCoffee()
    {
        Console.WriteLine("Pouring coffee");
        return new Coffee();
    }

    private static void ApplyJam(Toast toast) => Console.Write("Putting jam on the toast");

    private static void ApplyButter(Toast toast) => Console.Write("Putting butter on the toast");

    private static async Task<Toast> ToastBreadAsync(int slices)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Putting a slice of bread in the toaster");
        }

        Console.WriteLine("Start toasting...");
        await Task.Delay(3000);
        Console.WriteLine("Remove toast from toaster");

        return new Toast();
    }

    private static async Task<Toast> MakeToastWithButterAndJamAsync(int slices)
    {
        var toast = await ToastBreadAsync(slices);
        ApplyButter(toast);
        ApplyJam(toast);

        return new Toast();
    }

    private static async Task<Bacon> FryBaconAsync(int slices)
    {
        Console.WriteLine($"putting {slices} slices of bacon in the pan");
        Console.WriteLine("cooking first side of bacon...");
        await Task.Delay(3000);

        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("flipping a slice of bacon");
        }

        Console.WriteLine("cooking the second side of bacon...");
        await Task.Delay(3000);
        Console.WriteLine("Put bacon on plate");

        return new Bacon();
    }

    private static async Task<Egg> FryEggsAsync(int howMany)
    {
        Console.WriteLine("Warming the egg pan...");
        await Task.Delay(3000);

        Console.WriteLine($"cracking {howMany} eggs");
        Console.WriteLine("cooking the eggs ...");
        await Task.Delay(3000);
        Console.WriteLine("Put eggs on plate");

        return new Egg();
    }

}
