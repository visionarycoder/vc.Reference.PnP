---
title: Builder
description: Construct a complex object step by step while keeping construction separate from its representation.
---

# Builder

## Intent

Separate the construction of a complex object from its representation so the same process can create different representations.

## Use when

An object has optional parts or must be assembled through a deliberate sequence of steps.

## Avoid when

A simple constructor or object initializer communicates the construction clearly.

## Source

Start with [IComputerBuilder.cs](IComputerBuilder.cs), [ComputerBuilder.cs](ComputerBuilder.cs), and [ComputerDirector.cs](ComputerDirector.cs). [Computer.cs](Computer.cs) is the resulting product.
