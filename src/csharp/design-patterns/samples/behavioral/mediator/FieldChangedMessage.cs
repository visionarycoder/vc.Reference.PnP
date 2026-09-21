namespace Snippets.DesignPatterns.Samples.Behavioral.Mediator;

public record FieldChangedMessage(string FieldName, object? Value);