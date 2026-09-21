namespace Snippets.DesignPatterns.Samples.Behavioral.ChainOfResponsibility;

public class GeneralSupportHandler() : SupportHandler("General Support")
{
    protected override async Task<TicketResponse?> ProcessRequestAsync(SupportTicket ticket)
    {
        await Task.Delay(8);

        Console.WriteLine($"[{HandlerName}] 📞 General ticket #{ticket.Id} assigned to general support");
        return TicketResponse.Handle(HandlerName, "Support Agent",
            "General inquiry assigned to support team", TimeSpan.FromDays(2));
    }
}