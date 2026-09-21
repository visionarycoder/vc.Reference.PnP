---
title: Composite
description: Composes objects into tree structures and treats leaves and groups uniformly.
---

# Composite

## Intent

Represent part-whole hierarchies so clients can use individual objects and compositions uniformly.

## Use when

Clients need to perform the same operation over leaves and nested groups.

## Avoid when

The object graph is not a meaningful hierarchy or leaf and group operations differ substantially.

## Required files

- [Roles.cs](Roles.cs): [Component](Roles.cs), [Leaf](Roles.cs), and [Composite](Roles.cs).
