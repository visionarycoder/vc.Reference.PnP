namespace Snippets.DesignPatterns.Structural.Facade;

public sealed class SubsystemA
{
    public string Operation() => "Subsystem A";
}

public sealed class SubsystemB
{
    public string Operation() => "Subsystem B";
}

public sealed class Facade(SubsystemA subsystemA, SubsystemB subsystemB)
{
    public string Operation() => $"{subsystemA.Operation()}; {subsystemB.Operation()}";
}
