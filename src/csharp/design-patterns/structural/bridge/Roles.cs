namespace Snippets.DesignPatterns.Structural.Bridge;

public abstract class Implementor
{
    public abstract string OperationImplementation();
}

public sealed class ConcreteImplementor : Implementor
{
    public override string OperationImplementation() => "Implemented operation";
}

public abstract class Abstraction(Implementor implementor)
{
    protected Implementor Implementor { get; } = implementor;

    public virtual string Operation() => Implementor.OperationImplementation();
}

public sealed class RefinedAbstraction(Implementor implementor) : Abstraction(implementor)
{
    public override string Operation() => $"Refined: {base.Operation()}";
}
