namespace Snippets.DesignPatterns.Behavioral.Memento;

public sealed record Memento<T>(T State);

public sealed class Originator<T>(T state)
{
    public T State { get; set; } = state;

    public Memento<T> Save() => new(State);

    public void Restore(Memento<T> memento) => State = memento.State;
}

public sealed class Caretaker<T>
{
    private readonly Stack<Memento<T>> history = [];

    public void Save(Originator<T> originator) => history.Push(originator.Save());

    public bool Undo(Originator<T> originator)
    {
        if (!history.TryPop(out var memento)) return false;
        originator.Restore(memento);
        return true;
    }
}
