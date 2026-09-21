using Snippets.DesignPatterns.Creational.Builder;
using Snippets.DesignPatterns.Structural.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests;

[TestClass]
public sealed class ReferenceSmokeTests
{
    [TestMethod]
    public void BuilderCreatesAnIndependentProduct()
    {
        var builder = new ConcreteBuilder();

        builder.BuildPart("Part A");
        builder.BuildPart("Part B");
        var product = builder.GetResult();

        CollectionAssert.AreEqual(new[] { "Part A", "Part B" }, product.Parts.ToArray());

        builder.Reset();
        Assert.AreEqual(0, builder.GetResult().Parts.Count);
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
