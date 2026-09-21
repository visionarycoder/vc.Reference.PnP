namespace Snippets.DesignPatterns.Behavioral.State;

public interface IState<T>
{
    T Handle(T input);
}

public sealed class Context<T>(IState<T> state)
{
    public IState<T> State { get; set; } = state;

    public T Request(T input) => State.Handle(input);
}

public sealed class DelegateState<T>(Func<T, T> handle) : IState<T>
{
    public T Handle(T input) => handle(input);
}
