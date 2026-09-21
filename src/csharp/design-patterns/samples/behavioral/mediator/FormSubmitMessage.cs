namespace Snippets.DesignPatterns.Samples.Behavioral.Mediator;

public record FormSubmitMessage(Dictionary<string, object?> FormData);