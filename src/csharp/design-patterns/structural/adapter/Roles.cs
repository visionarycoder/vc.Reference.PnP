namespace Snippets.DesignPatterns.Structural.Adapter;

public abstract class Target
{
    public abstract string Request();
}

public sealed class Adaptee
{
    public string SpecificRequest() => "Specific request";
}

public sealed class Adapter(Adaptee adaptee) : Target
{
    public override string Request() => adaptee.SpecificRequest();
}
