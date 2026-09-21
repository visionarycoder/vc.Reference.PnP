namespace Snippets.DesignPatterns.Samples.Structural.Facade;

public class DatabaseConnection(string connectionString)
{
    private bool isConnected;

    public void Connect()
    {
        Console.WriteLine($"🗄️ Connecting to database: {connectionString}");
        Thread.Sleep(150);
        isConnected = true;
        Console.WriteLine("✅ Database connected");
    }

    public void ExecuteQuery(string sql, Dictionary<string, object>? parameters = null)
    {
        if (!isConnected)
            throw new InvalidOperationException("Not connected to database");

        Console.WriteLine($"🔍 Executing SQL: {sql}");
        if (parameters != null && parameters.Count > 0)
        {
            Console.WriteLine($"   Parameters: {string.Join(", ", parameters)}");
        }

        Thread.Sleep(100);
        Console.WriteLine("✅ Query executed");
    }

    public T QuerySingle<T>(string sql, Dictionary<string, object>? parameters = null)
    {
        ExecuteQuery(sql, parameters);
        return default(T)!; // Simulate return
    }

    public void Disconnect()
    {
        if (isConnected)
        {
            Console.WriteLine("🗄️ Disconnecting from database");
            isConnected = false;
            Console.WriteLine("✅ Database disconnected");
        }
    }
}