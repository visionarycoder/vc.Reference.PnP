namespace Snippets.DesignPatterns.Samples.Structural.Decorator;

public interface IBeverage
{
    string GetDescription();
    decimal GetCost();
    int GetCalories();
    string GetSize();
}