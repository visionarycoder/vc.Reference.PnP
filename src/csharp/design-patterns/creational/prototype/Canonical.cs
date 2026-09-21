namespace Snippets.DesignPatterns.Creational.Prototype;

public sealed class Prototype(string value)
{
    public string Value { get; } = value;

    public Prototype Clone() => new(Value);
}
