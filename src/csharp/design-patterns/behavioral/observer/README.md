---
title: Observer
description: Notify dependent objects automatically when a subject changes.
---

# Observer

## Intent

Define a one-to-many dependency so a change to one object notifies its dependents.

## Use when

Independent listeners must react to state changes without the subject knowing their concrete types.

## Avoid when

Notification ordering, delivery guarantees, or lifecycle ownership need a stronger messaging abstraction.

## Source

See the [C# sample](.).
