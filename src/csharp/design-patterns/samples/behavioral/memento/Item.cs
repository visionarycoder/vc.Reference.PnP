namespace Snippets.DesignPatterns.Samples.Behavioral.Memento;

/// <summary>
/// Game item record
/// </summary>
public record Item(string Name, string Type, int Quantity, Dictionary<string, object> Properties);