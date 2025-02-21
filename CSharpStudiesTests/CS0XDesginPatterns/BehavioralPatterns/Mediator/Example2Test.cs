using CS0XDesignPatterns.BehavioralPatterns.Mediator.Example2;
using CS0XDesignPatterns.BehavioralPatterns.Mediator.Example2.Commands;
using FluentAssertions;

namespace CSharpStudiesTests.CS0XDesginPatterns.BehavioralPatterns.Mediator;

public class Example2Test
{
    [Fact(DisplayName = @"
          DADO
            Que Mourinho escalou o time BarSemLona
          QUANDO
            Durante o jogo ele decide fazer uma substituição
          ENTÃO
            Quando o quarto árbitro levanta a placa
            Sai Maradona
            Entra Eduardo")]
    public async void Handle_ShouldSubstituteMaradonaWithEduardo()
    {
        var coach = new Coach("Mourinho");
        var fourthReferee = new FourthReferee("Daronco");
        var game = new Game();

        var command = new SubstitutionPlayerCommand(
            coach,
            coach.Team.FirstOrDefault(pi => pi.Name == "Maradona")!,
            coach.Team.FirstOrDefault(po => po.Name == "Eduardo")!,
            fourthReferee,
            game);

        var handler = new SubstitutionPlayerCommandHandler();

        var team = await handler.Handle(command, new CancellationToken());

        team.FirstOrDefault(p => p.Name == "Maradona")!.IsOnTheGame.Should().BeFalse();
        team.FirstOrDefault(p => p.Name == "Eduardo")!.IsOnTheGame.Should().BeTrue();

    }
}
