using CS0XDesignPatterns.BehavioralPatterns.Mediator.Abstractions;

namespace CS0XDesignPatterns.BehavioralPatterns.Mediator;

public static class Mediator
{
    public static void Execute()
    {
        IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

        User lucas = new ConcreteUser(facebookMediator, "Lucas");
        User eduardo = new ConcreteUser(facebookMediator, "Eduardo");
        User renata = new ConcreteUser(facebookMediator, "Renata");
        User lara = new ConcreteUser(facebookMediator, "Lara");
        
        facebookMediator.RegisterUser(lucas);
        facebookMediator.RegisterUser(eduardo);
        facebookMediator.RegisterUser(renata);
        facebookMediator.RegisterUser(lara);
        
        lucas.Send("Mediator Pattern!");
    }
}