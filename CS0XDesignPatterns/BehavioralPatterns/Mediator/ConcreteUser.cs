using CS0XDesignPatterns.BehavioralPatterns.Mediator.Abstractions;

namespace CS0XDesignPatterns.BehavioralPatterns.Mediator;

public class ConcreteUser : User
{
    public ConcreteUser(IFacebookGroupMediator mediator, string name) : base(mediator, name)
    {
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name}: Mensagem recebida: \"{message}\" às {DateTime.Now.ToLongTimeString()}");
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name}: Enviando mensagem: \"{message}\" às {DateTime.Now.ToLongTimeString()}");
        Mediator.SendMessage(message, this);
    }
}