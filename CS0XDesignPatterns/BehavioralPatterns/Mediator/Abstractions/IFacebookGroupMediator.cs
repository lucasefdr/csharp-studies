namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Abstractions;

// Mediator: define a interface para comunicação entre objetos
public interface IFacebookGroupMediator
{
    void RegisterUser(User user);
    void SendMessage(string messagem, User user);
}