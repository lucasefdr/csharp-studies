namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example2;

public class Coach
{

    public Coach(string name)
    {
        ID = Guid.NewGuid();
        Name = name;
        Team = ScaleTeam();
    }

    public Guid ID { get; private set; }
    public string Name { get; private set; }
    public IEnumerable<Player> Team { get; private set; }

    public string SubstitutePlayer(Player playerIn, Player playerOut)
        => $"I want to substitute {playerOut.Name} with {playerIn.Name}";

    private IEnumerable<Player> ScaleTeam()
    {
        string[] playerNames = [
        "Marcos", "Cafú", "Maldini", "Baresi", "Roberto Carlos", "Zidane", "Maradona",
        "Cristiano Ronaldo", "Messi", "Ronaldo", "Pelé", "Lucas", "Eduardo", "Zico"
        ];

        for (int i = 0; i < playerNames.Length; i++)
        {
            if (i <= 11) yield return new Player(playerNames[i], i, true);
            else yield return new Player(playerNames[i], i, false);
        }
    }
}
