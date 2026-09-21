namespace Snippets.DesignPatterns.Samples.Behavioral.Memento;

/// <summary>
/// Originator interface for objects that can create and restore from mementos
/// </summary>
public interface IOriginator<T> where T : IMemento
{
    T CreateMemento();
    void RestoreFromMemento(T memento);
}