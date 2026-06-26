namespace Patterns.Singleton.Example;

public sealed class SingletonExample
{
    
    private static readonly Lazy<SingletonExample> lazy = new(() => new SingletonExample());

    public static SingletonExample Instance => lazy.Value;

    private SingletonExample() 
    { 
    }
    
}
