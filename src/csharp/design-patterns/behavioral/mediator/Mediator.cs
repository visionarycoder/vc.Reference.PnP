namespace Snippets.DesignPatterns.Behavioral.Mediator;

public interface IMediator
{
    void Notify(Colleague sender, string message);
}

public abstract class Colleague(IMediator mediator)
{
    protected void Send(string message) => mediator.Notify(this, message);
}

public sealed class ActionMediator(Action<Colleague, string> notify) : IMediator
{
    public void Notify(Colleague sender, string message) => notify(sender, message);
}
