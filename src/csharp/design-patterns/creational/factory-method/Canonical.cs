namespace Snippets.DesignPatterns.Creational.Factory;

public interface IProduct
{
    string Operation();
}

public abstract class Creator
{
    public abstract IProduct CreateProduct();

    public string SomeOperation() => CreateProduct().Operation();
}

public sealed class ConcreteCreator : Creator
{
    public override IProduct CreateProduct() => new ConcreteProduct();
}

public sealed class ConcreteProduct : IProduct
{
    public string Operation() => "Concrete product";
}
