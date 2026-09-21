namespace Snippets.DesignPatterns.Behavioral.Interpreter;

public interface IExpression
{
    int Interpret(IReadOnlyDictionary<string, int> context);
}

public sealed class NumberExpression(int value) : IExpression
{
    public int Interpret(IReadOnlyDictionary<string, int> context) => value;
}

public sealed class VariableExpression(string name) : IExpression
{
    public int Interpret(IReadOnlyDictionary<string, int> context) => context[name];
}

public sealed class AddExpression(IExpression left, IExpression right) : IExpression
{
    public int Interpret(IReadOnlyDictionary<string, int> context) => left.Interpret(context) + right.Interpret(context);
}
