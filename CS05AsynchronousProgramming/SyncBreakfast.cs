namespace CS05AsynchronousProgramming;

internal class SyncBreakfast
{
    private class Bacon { }
    private class Coffee { }
    private class Egg { }
    private class Juice { }
    private class Toast { }

    public static void MakeSyncBreakfast()
    {
        Console.WriteLine("=> Making a breakfast sync");

        var cup = PourCoffee();
        Console.WriteLine("Coffee is ready");

        var eggs = FryEggs(2);
        Console.WriteLine("Eggs are ready");

        var bacon = FryBacon(4);
        Console.WriteLine("Bacon is ready");

        var toast = ToastBread(2);
        ApplyJam(toast);
        ApplyButter(toast);
        Console.WriteLine("Toast is ready");

        var juice = PourOJ();
        Console.WriteLine("Orange juice is ready");

        Console.WriteLine("=> Breakfast sync is ready");
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

    private static Toast ToastBread(int slices)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Putting a slice of bread in the toaster");
        }

        Console.WriteLine("Start toasting...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Remove toast from toaster");

        return new Toast();
    }

    private static Bacon FryBacon(int slices)
    {
        Console.WriteLine($"putting {slices} slices of bacon in the pan");
        Console.WriteLine("cooking first side of bacon...");
        Task.Delay(3000).Wait();
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("flipping a slice of bacon");
        }
        Console.WriteLine("cooking the second side of bacon...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Put bacon on plate");

        return new Bacon();
    }

    private static Egg FryEggs(int howMany)
    {
        Console.WriteLine("Warming the egg pan...");
        Task.Delay(3000).Wait();
        Console.WriteLine($"cracking {howMany} eggs");
        Console.WriteLine("cooking the eggs ...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Put eggs on plate");

        return new Egg();
    }
}
