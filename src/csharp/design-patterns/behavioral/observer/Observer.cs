namespace Snippets.DesignPatterns.Behavioral.Observer;

public interface IObserver<in T>
{
    void Update(T value);
}

public interface ISubject<T>
{
    void Attach(IObserver<T> observer);

    void Detach(IObserver<T> observer);
}

public sealed class Subject<T> : ISubject<T>
{
    private readonly HashSet<IObserver<T>> observers = [];

    public void Attach(IObserver<T> observer) => observers.Add(observer);

    public void Detach(IObserver<T> observer) => observers.Remove(observer);

    public void Notify(T value)
    {
        foreach (var observer in observers) observer.Update(value);
    }
}
