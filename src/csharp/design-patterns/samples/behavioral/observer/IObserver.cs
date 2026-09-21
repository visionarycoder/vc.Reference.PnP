namespace Snippets.DesignPatterns.Samples.Behavioral.Observer;

public interface IObserver<T>
{
    void Update(T data);
    string Name { get; }
}