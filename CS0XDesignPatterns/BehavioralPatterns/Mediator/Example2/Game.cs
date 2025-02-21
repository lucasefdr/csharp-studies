namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example2;

public class Game
{
    public IEnumerable<Player> SubstitutePlayers(IEnumerable<Player> team, Player playerIn, Player playerOut)
    {
        var teamAfterPlayerLeft = PlayerOut(team, playerOut);
        return PlayerIn(teamAfterPlayerLeft, playerIn);
    }

    private static IEnumerable<Player> PlayerIn(IEnumerable<Player> team, Player playerIn)
    {
        foreach (var player in team)
        {
            if (playerIn.Name == player.Name)
            {
                player.EnterTheGame();
                yield return player;
            }
            yield return player;
        }
    }

    private static IEnumerable<Player> PlayerOut(IEnumerable<Player> team, Player playerOut)
    {
        foreach (var player in team)
        {
            if (playerOut.Name == player.Name)
            {
                player.ExitTheGame();
                yield return player;
            }
            yield return player;
        }
    }
}
