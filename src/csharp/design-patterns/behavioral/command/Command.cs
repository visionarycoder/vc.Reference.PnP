namespace Snippets.DesignPatterns.Behavioral.Command;

public interface ICommand
{
    void Execute();
}

public sealed class CommandQueue
{
    private readonly Queue<ICommand> commands = [];

    public void Enqueue(ICommand command) => commands.Enqueue(command);

    public void ExecuteAll()
    {
        while (commands.TryDequeue(out var command))
        {
            command.Execute();
        }
    }
}

public sealed class ActionCommand(Action action) : ICommand
{
    public void Execute() => action();
}
