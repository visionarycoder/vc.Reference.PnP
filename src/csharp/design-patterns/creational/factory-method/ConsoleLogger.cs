namespace Snippets.DesignPatterns.Creational.Factory;

/// <summary>
/// Concrete product: Console logger
/// </summary>
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[CONSOLE] {message}");
    }

    public void LogError(string error)
    {
        Console.WriteLine($"[ERROR] {error}");
    }
}
