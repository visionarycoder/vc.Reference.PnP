namespace Snippets.DesignPatterns.Structural.Decorator;

public interface ITextProcessor
{
    string Process(string text);
    string GetDescription();
    decimal GetProcessingCost();
}

public sealed class BasicTextProcessor : ITextProcessor
{
    public string Process(string text) => text;
    public string GetDescription() => "Basic Text";
    public decimal GetProcessingCost() => 1;
}

public abstract class TextDecorator(ITextProcessor component) : ITextProcessor
{
    protected ITextProcessor Component { get; } = component;

    public virtual string Process(string text) => Component.Process(text);
    public virtual string GetDescription() => Component.GetDescription();
    public virtual decimal GetProcessingCost() => Component.GetProcessingCost();
}

public sealed class UpperCaseDecorator(ITextProcessor component) : TextDecorator(component)
{
    public override string Process(string text) => base.Process(text).ToUpperInvariant();
    public override string GetDescription() => $"{base.GetDescription()} + UpperCase";
    public override decimal GetProcessingCost() => base.GetProcessingCost() + 2;
}
