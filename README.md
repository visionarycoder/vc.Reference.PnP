# C# GoF Design Patterns Reference

A buildable, modern-C# reference for the 23 Gang of Four patterns. Start with the task you need to solve, then open the linked pattern folder for its intent, trade-offs, and source.

## Requirements and verification

- .NET 10 SDK
- C# 14

```powershell
dotnet build vc.PnP.slnx --configuration Release
dotnet run --project tests/unit/DesignPatterns.Tests --configuration Release
```

## Find a pattern

| If you need to… | Pattern |
| --- | --- |
| Create related objects without naming concrete classes | [Abstract Factory](src/csharp/design-patterns/creational/abstract-factory/) |
| Build a complex value in steps | [Builder](src/csharp/design-patterns/creational/builder/) |
| Delegate object creation to subclasses or a factory | [Factory Method](src/csharp/design-patterns/creational/factory-method/) |
| Copy a configured object | [Prototype](src/csharp/design-patterns/creational/prototype/) |
| Coordinate access to one shared instance | [Singleton](src/csharp/design-patterns/creational/singleton/) |
| Convert one interface into another | [Adapter](src/csharp/design-patterns/structural/adapter/) |
| Separate an abstraction from its implementation | [Bridge](src/csharp/design-patterns/structural/bridge/) |
| Treat leaves and object trees uniformly | [Composite](src/csharp/design-patterns/structural/composite/) |
| Add behavior without subclassing | [Decorator](src/csharp/design-patterns/structural/decorator/) |
| Simplify a complex subsystem | [Facade](src/csharp/design-patterns/structural/facade/) |
| Share repeatable intrinsic state | [Flyweight](src/csharp/design-patterns/structural/flyweight/) |
| Control access while preserving an interface | [Proxy](src/csharp/design-patterns/structural/proxy/) |
| Pass a request through possible handlers | [Chain of Responsibility](src/csharp/design-patterns/behavioral/chain-of-responsibility/) |
| Encapsulate a request for undo, queuing, or logging | [Command](src/csharp/design-patterns/behavioral/command/) |
| Represent a small grammar as an object model | [Interpreter](src/csharp/design-patterns/behavioral/interpreter/) |
| Traverse an aggregate without exposing its representation | [Iterator](src/csharp/design-patterns/behavioral/iterator/) |
| Centralize complex object collaboration | [Mediator](src/csharp/design-patterns/behavioral/mediator/) |
| Capture and restore state | [Memento](src/csharp/design-patterns/behavioral/memento/) |
| Notify dependents about a change | [Observer](src/csharp/design-patterns/behavioral/observer/) |
| Change behavior when internal state changes | [State](src/csharp/design-patterns/behavioral/state/) |
| Select an interchangeable algorithm | [Strategy](src/csharp/design-patterns/behavioral/strategy/) |
| Fix an algorithm skeleton while allowing steps to vary | [Template Method](src/csharp/design-patterns/behavioral/template-method/) |
| Add operations to a stable object structure | [Visitor](src/csharp/design-patterns/behavioral/visitor/) |

## Layout

```text
src/csharp/design-patterns/
├── creational/  # 5 patterns
├── structural/  # 7 patterns
└── behavioral/  # 11 patterns
tests/
└── unit/
```

Every pattern folder contains its C# example and a focused README. Integration tests, when needed, belong under `tests/integration/`.

## Supporting guidance

Supplementary architecture guidance is available in [docs/best-practices](docs/best-practices/).
