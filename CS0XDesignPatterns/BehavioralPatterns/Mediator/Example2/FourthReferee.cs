namespace CS0XDesignPatterns.BehavioralPatterns.Mediator.Example2;

public class FourthReferee(string name)
{
    public Guid ID { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; } = name;

    public string SubstitutionBoard​​(int numberIn, int numberLeft)
        => $@"In  [{numberIn}]
              Out [{numberLeft}]";
}
