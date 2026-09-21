namespace Snippets.DesignPatterns.Samples.Behavioral.Iterator;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
    T Current { get; }
}