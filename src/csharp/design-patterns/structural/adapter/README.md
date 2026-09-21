---
title: Adapter
description: Converts one interface into another interface a client expects.
---

# Adapter

## Intent

Allow incompatible interfaces to collaborate by translating requests at the boundary.

## Use when

An existing component must satisfy an interface it was not designed to implement.

## Avoid when

You control both APIs and can align their contracts directly.

## Required files

- [Roles.cs](Roles.cs): [Target](Roles.cs), [Adaptee](Roles.cs), and [Adapter](Roles.cs).
