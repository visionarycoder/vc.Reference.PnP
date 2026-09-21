---
title: Decorator
description: Adds responsibilities to an object dynamically through composition.
---

# Decorator

## Intent

Attach responsibilities to an object dynamically without changing its concrete type.

## Use when

Behavior must be combined selectively or at runtime without a subclass for every combination.

## Avoid when

The behavior is intrinsic and fixed for every instance of a type.

See [TextDecorator.cs](TextDecorator.cs) and [ITextProcessor.cs](ITextProcessor.cs).
