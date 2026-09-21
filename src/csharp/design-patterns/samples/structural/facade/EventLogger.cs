using System.Text.Json;

namespace Snippets.DesignPatterns.Samples.Structural.Facade;

public class EventLogger
{
    private readonly List<string> events = [];

    public void LogEvent(string eventType, string description, object? data = null)
    {
        var eventEntry = $"{DateTime.Now:HH:mm:ss} - {eventType}: {description}";
        if (data != null)
        {
            eventEntry += $" | Data: {JsonSerializer.Serialize(data)}";
        }

        events.Add(eventEntry);
        Console.WriteLine($"📊 Event logged: {eventEntry}");
    }

    public IReadOnlyList<string> GetEvents() => events.AsReadOnly();
}