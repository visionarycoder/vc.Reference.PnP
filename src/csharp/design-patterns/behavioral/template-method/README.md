---
title: Template Method
description: Define an algorithm skeleton while allowing subclasses to vary selected steps.
---

# Template Method

## Intent

Define an algorithm's skeleton in a base type and defer selected steps to subclasses.

## Use when

Several algorithms share a stable sequence but vary at well-defined extension points.

## Avoid when

Composition through Strategy is clearer or inheritance would create rigid coupling.

## Source

See the [C# sample](.).
