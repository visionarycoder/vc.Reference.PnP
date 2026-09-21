namespace Snippets.DesignPatterns.Samples.Structural.Bridge;

public class EmergencyNotificationChannel(IMessageSender sender, string emergencyPrefix = "[EMERGENCY]")
    : NotificationChannel(sender)
{
    public override void Broadcast(string message)
    {
        var emergencyMessage = $"{emergencyPrefix} {message}";
        Console.WriteLine($"\n🆘 Emergency Broadcast to {Recipients.Count} recipients:");

        foreach (var recipient in Recipients)
        {
            Sender.SendMessage(emergencyMessage, recipient);
        }
    }
}