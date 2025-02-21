namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example2;

public class Player(string name, int number, bool isOnTheGame)
{
    public Guid ID { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = name;
    public int Number { get; private set; } = number;
    public bool IsOnTheGame { get; private set; } = isOnTheGame;

    public void ExitTheGame() => IsOnTheGame = false;
    public void EnterTheGame() => IsOnTheGame = true;
}
