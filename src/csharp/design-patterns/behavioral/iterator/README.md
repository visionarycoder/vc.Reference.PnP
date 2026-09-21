---
title: Iterator
description: Traverse an aggregate without exposing its internal representation.
---

# Iterator

## Intent

Provide sequential access to an aggregate without exposing how it stores elements.

## Use when

Clients need one or more traversal strategies over a collection or tree.

## Avoid when

Normal C# enumeration is sufficient and a custom traversal adds no meaningful behavior.

## Required files

- [Iterator.cs](Iterator.cs) — aggregate and iterator contracts with a list implementation.
