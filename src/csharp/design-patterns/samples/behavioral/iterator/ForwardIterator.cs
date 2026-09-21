namespace Snippets.DesignPatterns.Samples.Behavioral.Iterator;

public class ForwardIterator<T>(IList<T> items) : Iterator<T>(items);