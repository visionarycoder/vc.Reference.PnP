namespace Snippets.DesignPatterns.Creational.Builder;

public sealed record Product(IReadOnlyList<string> Parts);

public interface IBuilder
{
    void Reset();
    void BuildPart(string part);
    Product GetResult();
}

public sealed class ConcreteBuilder : IBuilder
{
    private readonly List<string> parts = [];

    public void Reset() => parts.Clear();

    public void BuildPart(string part) => parts.Add(part);

    public Product GetResult() => new([.. parts]);
}

public sealed class Director(IBuilder builder)
{
    public Product BuildMinimal()
    {
        builder.Reset();
        builder.BuildPart("Part A");
        return builder.GetResult();
    }
}
