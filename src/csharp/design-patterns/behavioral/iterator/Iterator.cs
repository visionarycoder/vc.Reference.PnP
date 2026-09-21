namespace Snippets.DesignPatterns.Behavioral.Iterator;

public interface IIterator<out T>
{
    bool MoveNext();

    T Current { get; }
}

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}

public sealed class ListAggregate<T>(IReadOnlyList<T> items) : IAggregate<T>
{
    public IIterator<T> CreateIterator() => new ListIterator<T>(items);
}

public sealed class ListIterator<T>(IReadOnlyList<T> items) : IIterator<T>
{
    private int index = -1;

    public T Current => index >= 0 && index < items.Count ? items[index] : throw new InvalidOperationException();

    public bool MoveNext() => ++index < items.Count;
}
