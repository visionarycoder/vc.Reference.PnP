---
title: Facade
description: Provides a simplified entry point to a complex subsystem.
---

# Facade

## Intent

Offer one focused interface for a subsystem while retaining its internal components.

## Use when

Clients commonly need the same coordinated sequence across several subsystem types.

## Avoid when

Clients require broad access to individual subsystem operations.

## Required files

- [Roles.cs](Roles.cs): [Facade](Roles.cs), [SubsystemA](Roles.cs), and [SubsystemB](Roles.cs).
