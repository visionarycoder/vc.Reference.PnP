namespace Snippets.DesignPatterns.Behavioral.Visitor;

public interface IVisitor<out TResult>
{
    TResult Visit(ElementA element);

    TResult Visit(ElementB element);
}

public interface IVisitable
{
    TResult Accept<TResult>(IVisitor<TResult> visitor);
}

public sealed class ElementA : IVisitable
{
    public TResult Accept<TResult>(IVisitor<TResult> visitor) => visitor.Visit(this);
}

public sealed class ElementB : IVisitable
{
    public TResult Accept<TResult>(IVisitor<TResult> visitor) => visitor.Visit(this);
}
