# C# GoF Design Patterns Reference

A compact, buildable reference implementation of the 23 Gang of Four design patterns in modern C#.

The examples are grouped by the original GoF categories. They are intentionally small, independent, and use only the .NET base class library so developers can inspect the essential collaboration in each pattern.

## Requirements

- .NET 10 SDK

## Build and run

```powershell
dotnet build VisionaryCoder.PnP.slnx
dotnet run --project src/csharp/design_patterns/DesignPatterns.Behavioral
```

## Pattern catalog

| Category | Patterns |
| --- | --- |
| Creational | Abstract Factory, Builder, Factory Method, Prototype, Singleton |
| Structural | Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy |
| Behavioral | Chain of Responsibility, Command, Interpreter, Iterator, Mediator, Memento, Observer, State, Strategy, Template Method, Visitor |

## Layout

```text
src/csharp/design_patterns/
├── DesignPatterns.Creational/
├── DesignPatterns.Structural/
└── DesignPatterns.Behavioral/
```

Each category project contains one folder per pattern. `DesignPatterns.Behavioral` also has a console runner that exercises its examples.

## Supporting guidance

The retained architecture guidance is available in [docs/best-practices](docs/best-practices/). It is supplementary reference material, not a prerequisite for using the pattern examples.

## Contributing

Keep examples focused on the pattern being illustrated, dependency-free where possible, and build the solution before submitting a change.
