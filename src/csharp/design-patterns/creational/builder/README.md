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

## Required files

- [Canonical.cs](Canonical.cs): product, builder contract, concrete builder, and director.
