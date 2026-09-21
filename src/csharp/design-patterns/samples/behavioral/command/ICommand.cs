namespace Snippets.DesignPatterns.Samples.Behavioral.Command;

public interface ICommand
{
    void Execute();
    void Undo();
    string Description { get; }
}