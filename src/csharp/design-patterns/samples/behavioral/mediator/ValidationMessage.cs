namespace Snippets.DesignPatterns.Samples.Behavioral.Mediator;

public record ValidationMessage(string FieldName, bool IsValid, string? ErrorMessage = null);