namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example1;

public class ComponentA : BaseComponent
{
    public void ExecuteActionA()
    {
        Console.WriteLine("A --- A --- A --- A");
        _mediator.Notify(this, "Action from A");
    }

    public void ExecuteReceiverA()
    {
        Console.WriteLine("  - Receiving from B into A...");
    }
}
