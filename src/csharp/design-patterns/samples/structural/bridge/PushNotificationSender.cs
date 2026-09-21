namespace Snippets.DesignPatterns.Samples.Structural.Bridge;

public class PushNotificationSender(string platform = "Firebase") : IMessageSender
{
    public void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"🔔 Push notification sent via {platform}");
        Console.WriteLine($"   Device ID: {recipient}");
        Console.WriteLine($"   Message: {message}");
        Console.WriteLine($"   Status: ✅ Pushed to device");
    }

    public string GetSenderType() => "Push Notification";
}