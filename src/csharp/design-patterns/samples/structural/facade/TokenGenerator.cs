using System.Text;

namespace Snippets.DesignPatterns.Samples.Structural.Facade;

public class TokenGenerator
{
    public string GenerateVerificationToken()
    {
        Console.WriteLine("🎟️ Generating verification token");
        var token = Guid.NewGuid().ToString("N")[..16];
        Console.WriteLine($"✅ Token generated: {token}");
        return token;
    }

    public string GeneratePasswordResetToken(string email)
    {
        Console.WriteLine($"🔑 Generating password reset token for {email}");
        var token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{email}_{DateTime.Now.Ticks}"));
        Console.WriteLine($"✅ Reset token generated");
        return token;
    }
}