using System.Diagnostics;

namespace Snippets.DesignPatterns.Behavioral;

/// <summary>Provides opt-in diagnostics without making pattern implementations depend on terminal rendering.</summary>
internal static class PatternDiagnostics
{
    [Conditional("DEBUG")]
    public static void WriteLine<T>(T value) => Debug.WriteLine(value);

    [Conditional("DEBUG")]
    public static void WriteLine() => Debug.WriteLine(string.Empty);
}
