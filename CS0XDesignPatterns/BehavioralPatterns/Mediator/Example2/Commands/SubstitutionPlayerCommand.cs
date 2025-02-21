using MediatR;

namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example2.Commands;

public class SubstitutionPlayerCommand(
    Coach coach,
    Player playerIn,
    Player playerOut,
    FourthReferee fourthReferee,
    Game game) : IRequest<IEnumerable<Player>>
{
    public Coach Coach { get; private set; } = coach;
    public Player PlayerInGame { get; private set; } = playerIn;
    public Player PlayerToEnter { get; private set; } = playerOut;
    public FourthReferee FourthReferee { get; private set; } = fourthReferee;
    public Game Game { get; private set; } = game;
}
