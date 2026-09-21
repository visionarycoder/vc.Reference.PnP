---
title: Singleton
description: Provide a single, globally accessible instance with controlled initialization.
---

# Singleton

## Intent

Ensure a class has one instance and provide a global access point to it.

## Use when

Exactly one shared instance represents a genuine application-wide resource or policy.

## Avoid when

Dependencies should be explicit, lifetimes are scoped, or tests need substitutes; prefer dependency injection in those cases.

## Required files

- [Canonical.cs](Canonical.cs): a lazy, thread-safe singleton access point.
