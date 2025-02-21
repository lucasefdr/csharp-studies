namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example1;

public abstract class BaseComponent
{
    protected IMediator _mediator;

    public BaseComponent(IMediator mediator = null!)
    {
        _mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}
