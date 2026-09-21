---
title: Abstract Factory
description: Create related user-interface components without coupling callers to concrete platforms.
---

# Abstract Factory

## Intent

Provide an interface for creating families of related objects without specifying their concrete classes.

## Use when

You must select a coherent family of products, such as platform-specific UI controls, at runtime.

## Avoid when

Only one product varies independently; use Factory Method instead.

## Source

Start with [IUIFactory.cs](IUIFactory.cs), [UIFactoryProvider.cs](UIFactoryProvider.cs), and [Application.cs](Application.cs). The platform-specific factories and controls show each product family.
