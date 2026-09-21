namespace Snippets.DesignPatterns.Behavioral.ChainOfResponsibility;

public interface IHandler<in TRequest>
{
    bool Handle(TRequest request);
}

public abstract class Handler<TRequest>(IHandler<TRequest>? next = null) : IHandler<TRequest>
{
    public bool Handle(TRequest request) => CanHandle(request) || next?.Handle(request) == true;

    protected abstract bool CanHandle(TRequest request);
}
