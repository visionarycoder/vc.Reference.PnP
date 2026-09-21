namespace Snippets.DesignPatterns.Creational.AbstractFactory;

public interface IAbstractProductA
{
    string OperationA();
}

public interface IAbstractProductB
{
    string OperationB();
}

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

public sealed class ConcreteFactory : IAbstractFactory
{
    public IAbstractProductA CreateProductA() => new ConcreteProductA();

    public IAbstractProductB CreateProductB() => new ConcreteProductB();
}

public sealed class ConcreteProductA : IAbstractProductA
{
    public string OperationA() => "Product A";
}

public sealed class ConcreteProductB : IAbstractProductB
{
    public string OperationB() => "Product B";
}
