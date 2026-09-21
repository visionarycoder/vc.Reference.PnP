namespace Snippets.DesignPatterns.Samples.Structural.Proxy;

public class User
{
    public string Username { get; init; } = "";
    public UserRole Role { get; init; }
    public DateTime LastLogin { get; init; }
}