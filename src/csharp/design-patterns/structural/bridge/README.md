---
title: Bridge
description: Separates an abstraction from its implementation so both can vary independently.
---

# Bridge

## Intent

Decouple an abstraction from its implementation so each can change independently.

## Use when

Two independent dimensions of variation would otherwise produce a growing inheritance hierarchy.

## Avoid when

The abstraction and implementation are stable and have no independent variation.

## Required files

- [Roles.cs](Roles.cs): [Abstraction](Roles.cs), [RefinedAbstraction](Roles.cs), [Implementor](Roles.cs), and [ConcreteImplementor](Roles.cs).
