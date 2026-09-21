using Snippets.DesignPatterns.Creational.Builder;
using Snippets.DesignPatterns.Structural.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests;

[TestClass]
public sealed class ReferenceSmokeTests
{
    [TestMethod]
    public void BuilderCreatesAnIndependentConfiguredComputer()
    {
        var builder = new ComputerBuilder();

        var computer = builder
            .SetCpu("Test CPU")
            .SetRam(32)
            .AddAccessory("Keyboard")
            .Build();

        Assert.AreEqual("Test CPU", computer.Cpu);
        Assert.AreEqual(32, computer.Ram);
        CollectionAssert.Contains(computer.Accessories, "Keyboard");
        Assert.AreEqual(0, builder.Build().Accessories.Count);
    }

    [TestMethod]
    public void DecoratorComposesTextTransformations()
    {
        ITextProcessor processor = new UpperCaseDecorator(new BasicTextProcessor());

        Assert.AreEqual("GOF", processor.Process("gof"));
        Assert.AreEqual("Basic Text + UpperCase", processor.GetDescription());
        Assert.AreEqual(3, processor.GetProcessingCost());
    }
}
