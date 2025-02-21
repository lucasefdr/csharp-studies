namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example1;

public class Mediator : IMediator
{
    private readonly ComponentA _componentA;
    private readonly ComponentB _componentB;

    public Mediator(ComponentA componentA, ComponentB componentB)
    {
        _componentA = componentA;
        _componentA.SetMediator(this);

        _componentB = componentB;
        _componentB.SetMediator(this);
    }


    public void Notify(object sender, string eventMessage)
    {
        if (sender is ComponentA)
        {
            Console.WriteLine("Action from A - Hello, B!");
            _componentB.ExecuteReceiverB(); // Executando ação no B através do gatilho ComponentA
        }
        else if (sender is ComponentB)
        {
            Console.WriteLine("Action from B - Hello, A!");
            _componentA.ExecuteReceiverA(); // Executando ação no A através do gatilho ComponentB
        }
    }
}
