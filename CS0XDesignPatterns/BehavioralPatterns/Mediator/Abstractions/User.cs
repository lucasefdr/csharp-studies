namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Abstractions;

// Colleague: define a classe para comunicação com o Mediator
public abstract class User
{
    protected IFacebookGroupMediator Mediator;
    protected string Name;

    protected User(IFacebookGroupMediator mediator, string name)
    {
        Mediator = mediator;
        Name = name;
    }

    public abstract void Receive(string message);
    public abstract void Send(string message);
}