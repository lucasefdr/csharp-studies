namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example1;

public class ComponentB: BaseComponent
{
    public void ExecuteActionB()
    {
        Console.WriteLine("B --- B --- B --- B");
        _mediator.Notify(this, "Action from A");
    }

    public void ExecuteReceiverB()
    {
        Console.WriteLine("  - Receiving from A into B...");
    }
}
