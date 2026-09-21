namespace Snippets.DesignPatterns.Structural.Proxy;

public interface ISubject
{
    string Request();
}

public sealed class RealSubject : ISubject
{
    public string Request() => "Real subject request";
}

public sealed class Proxy(Func<ISubject> createSubject) : ISubject
{
    private readonly Lazy<ISubject> subject = new(createSubject);

    public string Request() => subject.Value.Request();
}
