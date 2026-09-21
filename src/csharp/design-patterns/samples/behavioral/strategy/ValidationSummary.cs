namespace Snippets.DesignPatterns.Samples.Behavioral.Strategy;

public record ValidationSummary(
    ValidationResult[] Results,
    bool AllValid,
    string[] AllWarnings);