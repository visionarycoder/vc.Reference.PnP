namespace Snippets.DesignPatterns.Samples.Structural.Proxy;

public interface IImage
{
    void Display();
    void Resize(int width, int height);
    string GetMetadata();
}