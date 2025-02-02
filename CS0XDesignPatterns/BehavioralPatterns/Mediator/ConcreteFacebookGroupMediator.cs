using CS0XDesignPatterns.BehavioralPatterns.Mediator.Abstractions;

namespace CS0XDesignPatterns.BehavioralPatterns.Mediator;

// ConcreteMediator: implementa a interface do Mediator e coordena a comunicação entre objetos
public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
{
    private List<User> _users = [];

    public void RegisterUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string messagem, User user)
    {
        _users.ForEach(u =>
        {
            if (u != user) u.Receive(messagem);
        });
    }
}