namespace Snippets.DesignPatterns.Behavioral.TemplateMethod;

public abstract class TemplateMethod<TInput, TOutput>
{
    public TOutput Execute(TInput input)
    {
        var prepared = Prepare(input);
        return Process(prepared);
    }

    protected virtual TInput Prepare(TInput input) => input;

    protected abstract TOutput Process(TInput input);
}
