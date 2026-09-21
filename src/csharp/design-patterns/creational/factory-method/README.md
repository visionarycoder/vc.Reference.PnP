---
title: Factory Method
description: Delegate selection of a concrete product to specialized factory implementations.
---

# Factory Method

## Intent

Define an interface for creating an object while letting implementations decide which concrete class to instantiate.

## Use when

Callers depend on a product abstraction and the concrete product is selected by context or configuration.

## Avoid when

You need coordinated creation of multiple related product types; use Abstract Factory instead.

## Source

Start with [ILogger.cs](ILogger.cs) and [LoggerFactory.cs](LoggerFactory.cs). The `Console`, `Database`, and `File` factory/product pairs demonstrate concrete choices.
