namespace Snippets.DesignPatterns.Samples.Structural.Bridge;

public class AlertMessage(string alertType, string content, IMessageSender messageSender)
    : Message(messageSender)
{
    private readonly string alertType = alertType ?? throw new ArgumentNullException(nameof(alertType));
    private readonly string content = content ?? throw new ArgumentNullException(nameof(content));
    private readonly DateTime timestamp = DateTime.Now;

    public override void Send(string recipient)
    {
        Console.WriteLine($"\n🚨 Sending {alertType} Alert:");
        var alertMessage = $"[{alertType.ToUpper()}] {content} (Sent: {timestamp:yyyy-MM-dd HH:mm:ss})";
        MessageSender.SendMessage(alertMessage, recipient);
    }
}