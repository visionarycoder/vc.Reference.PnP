namespace Snippets.DesignPatterns.Samples.Behavioral.Iterator;

public interface IIterable<T>
{
    IIterator<T> CreateIterator();
}