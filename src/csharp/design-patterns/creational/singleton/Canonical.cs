namespace Snippets.DesignPatterns.Creational.Singleton;

public sealed class Singleton<T>
    where T : class, new()
{
    private static readonly Lazy<T> instance = new(static () => new T());

    public static T Instance => instance.Value;
}
