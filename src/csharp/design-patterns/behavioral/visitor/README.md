---
title: Visitor
description: Add operations to a stable object structure without modifying its element types.
---

# Visitor

## Intent

Represent an operation to perform on elements of an object structure without changing their types.

## Use when

The element structure is stable and many distinct operations must be added over it.

## Avoid when

Element types change often, because every visitor must then be updated.

## Required files

- [Visitor.cs](Visitor.cs) — visitor, element, and double-dispatch contracts.
