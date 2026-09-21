namespace Snippets.DesignPatterns.Structural.Flyweight;

public sealed record Flyweight(string IntrinsicState)
{
    public string Operation(string extrinsicState) => $"{IntrinsicState}: {extrinsicState}";
}

public sealed class FlyweightFactory
{
    private readonly Dictionary<string, Flyweight> flyweights = [];

    public Flyweight Get(string intrinsicState) =>
        flyweights.TryGetValue(intrinsicState, out var flyweight)
            ? flyweight
            : flyweights[intrinsicState] = new Flyweight(intrinsicState);
}
