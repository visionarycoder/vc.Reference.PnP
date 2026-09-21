---
title: Strategy
description: Select an interchangeable algorithm independently of its clients.
---

# Strategy

## Intent

Define a family of algorithms, encapsulate each one, and make them interchangeable.

## Use when

Clients need to choose or change an algorithm without knowing its implementation details.

## Avoid when

The variations are trivial or a delegate would express the extension point more clearly.

## Required files

- [Strategy.cs](Strategy.cs) — strategy contract and configurable context.
