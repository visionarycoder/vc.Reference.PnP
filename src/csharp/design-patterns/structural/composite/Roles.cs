namespace Snippets.DesignPatterns.Structural.Composite;

public abstract class Component
{
    public abstract string Operation();

    public virtual void Add(Component component) => throw new NotSupportedException();
}

public sealed class Leaf : Component
{
    public override string Operation() => "Leaf";
}

public sealed class Composite : Component
{
    private readonly List<Component> children = [];

    public override string Operation() => string.Join(", ", children.Select(static child => child.Operation()));

    public override void Add(Component component) => children.Add(component);
}
