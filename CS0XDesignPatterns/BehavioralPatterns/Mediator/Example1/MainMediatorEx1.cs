namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example1;

public static class MainMediatorEx1
{
    public static void Execute()
    {
        var componentA = new ComponentA();
        var componentB = new ComponentB();

        new Mediator(componentA, componentB);

        componentA.ExecuteActionA();
        Console.WriteLine();
        componentB.ExecuteActionB();
    }
}
