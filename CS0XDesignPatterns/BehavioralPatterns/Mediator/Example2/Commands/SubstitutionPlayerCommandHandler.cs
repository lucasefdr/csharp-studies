using MediatR;

namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example2.Commands;

public class SubstitutionPlayerCommandHandler : IRequestHandler<SubstitutionPlayerCommand, IEnumerable<Player>>
{
    public Task<IEnumerable<Player>> Handle(SubstitutionPlayerCommand request, CancellationToken cancellationToken)
    {
        request.Coach.SubstitutePlayer(request.PlayerToEnter, request.PlayerInGame);
        request.FourthReferee.SubstitutionBoard(request.PlayerToEnter.Number, request.PlayerInGame.Number);

        return
            Task.FromResult(request.Game.SubstitutePlayers(request.Coach.Team, request.PlayerToEnter, request.PlayerInGame));
    }


}
