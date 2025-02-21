namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example1;

public interface IMediator
{
    void Notify(object sender, string eventMessage);
}
