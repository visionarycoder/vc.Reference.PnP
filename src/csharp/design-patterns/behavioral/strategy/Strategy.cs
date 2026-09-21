namespace Snippets.DesignPatterns.Behavioral.Strategy;

public interface IStrategy<in TInput, out TOutput>
{
    TOutput Execute(TInput input);
}

public sealed class Context<TInput, TOutput>(IStrategy<TInput, TOutput> strategy)
{
    public IStrategy<TInput, TOutput> Strategy { get; set; } = strategy;

    public TOutput Execute(TInput input) => Strategy.Execute(input);
}

public sealed class DelegateStrategy<TInput, TOutput>(Func<TInput, TOutput> execute) : IStrategy<TInput, TOutput>
{
    public TOutput Execute(TInput input) => execute(input);
}
